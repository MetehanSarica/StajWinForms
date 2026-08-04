# MVP Improvement & Fixes Plan
## StajWinForms — Bus Ticket Booking System

**Assessment date:** 2026-07-27
**Current MVP readiness:** ~60%
**Estimated effort to reach 85% (deployable pilot):** ~33 hours (~4 working days)

---

## 1. Executive Summary

3-tier bus ticket booking system:

- `StajWinForms/` — WinForms desktop app (DevExpress, .NET 10)
- `StajWinForms_API/` — ASP.NET Core 10 Web API (EF Core, LocalDB)
- `StajWeb/` — Razor Pages web + admin panel (.NET 10)

The project is **functionally complete** for its core flows (search trips, buy tickets, cancel, admin CRUD) but has **critical security and code-quality gaps** that must be closed before it can be shown to real users. Documentation is excellent. Architecture is sound. The main blockers are secrets in the repo, MD5 password hashing, missing server-side validation, and exposure of sensitive fields (salary) via the API.

**Good news:** No SQL injection, no XSS, no `NotImplementedException`, no dead half-built features. Transactions handle concurrent ticket sales correctly (Serializable isolation).

---

## 2. What Works (Do Not Touch)

- 3-tier separation is clean; DTO pattern used in the important controllers (`SeferDetay`, `Biletler`, `Kullanicilar`).
- EF Core LINQ everywhere — no raw SQL string concatenation.
- `SatinAlBilet` uses `Serializable` transaction with proper rollback on conflict (409).
- Client-side validation (TC 11 digits not starting with 0, phone 11 digits starting with 0) centralized in `StajWinForms/Helpers/Dogrulama.cs`.
- WinForms uses a proper singleton `HttpClient` via `Lazy<HttpClient>` in `AppConfig`.
- Web uses `IHttpClientFactory` named client — correct socket handling.
- Session cookie is `HttpOnly`, 30-minute idle timeout.
- API key comparison is now timing-safe (`CryptographicOperations.FixedTimeEquals`).
- Razor auto-encoding prevents XSS in reviewed pages.
- DevExpress UI is polished; QuestPDF ticket generation works.

---

## 3. Blocker Issues (Must Fix for MVP)

### 3.1 Secrets Committed to Repository — CRITICAL

**Files:**
- `StajWinForms_API/appsettings.json` — contains `ApiKey` + connection string
- `StajWinForms/appsettings.json` — contains `ApiKey`
- `StajWeb/Program.cs:9` — API key hardcoded in source

**Problem:** `staj-2026-gizli-anahtar` and the LocalDB connection string are in git history. `.gitignore` line 7 mentions "Secrets" but the files are already tracked.

**Fix:**
1. Move all `appsettings.json` files to `appsettings.Local.json` (git-ignored).
2. Commit `appsettings.Example.json` with placeholder values.
3. For dev: `dotnet user-secrets set "ApiKey" "..."` per project.
4. For production: environment variables (`ASPNETCORE_*`).
5. Rewrite history if the repo is public: `git filter-repo --path StajWinForms_API/appsettings.json --invert-paths`.
6. Rotate the API key after removal.

**Effort:** 2h

---

### 3.2 MD5 Password Hashing — CRITICAL

**Files:**
- `StajWinForms_API/Helpers/Md5Helper.cs`
- `StajWinForms_API/Controllers/AuthController.cs:23`
- `StajWinForms_API/Controllers/KullanicilarController.cs` (creates users with MD5)
- `db/adminpanel_tablolar.sql` — seed admin `Admin123` as `e64b78fc3bc91bcbc7dc232ba8ec59e0`

**Problem:** MD5 is cryptographically broken, unsalted, and instantly brute-forceable.

**Fix:** Use `Microsoft.AspNetCore.Identity.PasswordHasher<T>`.

```csharp
// AuthController
var hasher = new PasswordHasher<Kullanicilar>();
var user = await _context.Kullanicilars.FirstOrDefaultAsync(k => k.KullaniciAdi == dto.KullaniciAdi);
if (user is null) return Unauthorized();
var result = hasher.VerifyHashedPassword(user, user.SifreHash, dto.Sifre);
if (result == PasswordVerificationResult.Failed) return Unauthorized();
```

**Migration path:**
1. Add nullable `SifreHash` column alongside `SifreMd5`.
2. On successful MD5 login, transparently rehash and save `SifreHash`, null out `SifreMd5`.
3. Once all users migrated, drop `SifreMd5` column.
4. Delete `Md5Helper.cs`.

**Effort:** 3h

---

### 3.3 `PersonelController` Leaks Salaries — CRITICAL

**File:** `StajWinForms_API/Controllers/PersonelController.cs:21`

**Problem:** Returns raw `Personel` entity including `Maas` (salary) field to anyone with the API key.

**Fix:** Create `PersonelGosterDto` (no `Maas`) and project into it:

```csharp
public record PersonelGosterDto(int Id, string Ad, string Soyad, string? Gorev);

var list = await _context.Personels
    .Select(p => new PersonelGosterDto(p.Id, p.Ad, p.Soyad, p.Gorev))
    .ToListAsync();
```

Keep a separate `PersonelDetayDto` (with salary) for authorized admin endpoints only.

**Effort:** 2h

---

### 3.4 No Server-Side DTO Validation — HIGH

**Files:** All DTOs in `StajWinForms_API/Dtos/`

**Problem:** TC, phone, email etc. are re-checked in the client but not in the API. A Postman request with `MusteriTc = "abc"` will be accepted.

**Fix:** Add data annotations + rely on `[ApiController]`'s automatic 400 response:

```csharp
public class SatinAlDto
{
    [Required, RegularExpression(@"^[1-9]\d{10}$", ErrorMessage = "TC 11 haneli olmalı, 0 ile başlayamaz")]
    public string MusteriTc { get; set; } = "";

    [Required, RegularExpression(@"^0\d{10}$")]
    public string MusteriTelefon { get; set; } = "";

    [Required, EmailAddress]
    public string MusteriMail { get; set; } = "";

    [Required, StringLength(50, MinimumLength = 2)]
    public string MusteriAd { get; set; } = "";

    [Required, StringLength(50, MinimumLength = 2)]
    public string MusteriSoyad { get; set; } = "";

    [Required, RegularExpression(@"^[EK]$")]
    public string MusteriCinsiyet { get; set; } = "";

    [Range(1, int.MaxValue)] public int SeferId { get; set; }
    [Range(1, int.MaxValue)] public int BinisSirasi { get; set; }
    [Range(1, int.MaxValue)] public int InisSirasi { get; set; }
    [Range(1, 60)] public int KoltukNo { get; set; }
}
```

Apply the same pattern to `CreateBiletDto`, `LoginDto`, `KullaniciCreateDto`, all admin CRUD DTOs.

**Effort:** 4h

---

### 3.5 No CORS / Security Headers — HIGH

**File:** `StajWinForms_API/Program.cs`

**Fix:**

```csharp
builder.Services.AddCors(o => o.AddPolicy("Default", p =>
    p.WithOrigins("http://localhost:5000", "https://localhost:5001")
     .AllowAnyMethod().AllowAnyHeader()));

// ...
app.UseCors("Default");

app.Use(async (ctx, next) =>
{
    ctx.Response.Headers["X-Content-Type-Options"] = "nosniff";
    ctx.Response.Headers["X-Frame-Options"] = "DENY";
    ctx.Response.Headers["Referrer-Policy"] = "no-referrer";
    ctx.Response.Headers["Strict-Transport-Security"] = "max-age=31536000; includeSubDomains";
    await next();
});
```

**Effort:** 2h

---

### 3.6 No Server-Side Authorization on Admin Endpoints — HIGH

**Files:** `KullanicilarController.cs`, `FirmalarController.cs`, `OtobuslerController.cs`, `PersonelController.cs`, `OtobusKaptanController.cs`, `SeferPersonelController.cs`

**Problem:** UI in WinForms and Web respects per-form permission flags (`Ekle`, `Sil`, `Degistir`, `Ata`, `Kaldir`), but the API itself accepts any request with the shared API key. A user without "Sil" permission can still call `DELETE /api/kullanicilar/{id}` directly.

**Fix (minimum viable):**
1. On login, issue a short-lived JWT that includes user id + permissions.
2. Add `[Authorize]` on admin controllers, plus a custom `[HasYetki("Kullanicilar","Sil")]` filter that checks the JWT claim.
3. Keep the API key middleware for public site-to-API calls; add JWT for admin operations.

**Effort:** 6h (largest item; postpone to P1 if time-boxed)

---

## 4. Should-Fix Items (Ship-Blockers For Quality)

### 4.1 DTOs Missing for Simple Controllers

`FirmalarController`, `SehirlerController`, `OtobuslerController`, `OtobusKaptanController` return raw EF entities. This leaks navigation collections and internal FK ids into the JSON payload and couples the API contract to the DB schema.

**Fix:** Introduce `FirmaDto`, `SehirDto`, `OtobusDto`, etc. with only the fields the client needs. **Effort:** 3h

### 4.2 Duplicate `JsonSerializerOptions` and Model Classes in WinForms

- `new JsonSerializerOptions { PropertyNameCaseInsensitive = true }` recreated in `AnaMenu`, `BiletSorgula`, `FirmaBrowserForm`, and more.
- `SeferDetayModel` redefined in at least 3 forms.

**Fix:**
- Add `AppConfig.JsonOptions` as a static singleton.
- Move shared models to `StajWinForms/Models/` and delete duplicates.

**Effort:** 2h

### 4.3 API Endpoint Strings Scattered Across Forms

**Fix:** Add `static class ApiEndpoints { public const string Seferler = "/api/seferdetay"; ... }` and use it everywhere.

**Effort:** 1h

### 4.4 No Structured Logging

No `ILogger<T>` usage in controllers. `catch` in `SatinAlBilet` returns 500 with no log entry — production incidents will be impossible to diagnose.

**Fix:** Inject `ILogger<BiletlerController>`, log warnings on 409 conflicts, log errors with stack trace on 500. Consider Serilog + a rolling file sink for the pilot.

**Effort:** 2h

### 4.5 Web Pages Missing Null-Response Handling

`BiletSorgula.cshtml.cs` now has `?? new()` (good). Audit `Seferler.cshtml.cs`, `SeferDetay.cshtml.cs`, `Satinal.cshtml.cs`, and all admin pages for `GetFromJsonAsync<T>` calls without `?? new()` fallback — a null API response currently crashes with `NullReferenceException` on the next line.

**Effort:** 1h

### 4.6 Web Session Stores Full Permission Snapshot

`Oturum` puts the entire `LoginSonucDto` (id, username, name, permissions list) in session JSON. If an admin's permissions are revoked, the session keeps the old permissions until they log out.

**Fix:** Store only `KullaniciId`. Re-fetch permissions on each request (cache in `HttpContext.Items` for the request duration).

**Effort:** 2h

### 4.7 Anti-Forgery Tokens on Admin Forms

Razor Pages admin forms should include `@Html.AntiForgeryToken()`. Without it, a logged-in admin visiting a malicious page can be tricked into deleting users.

**Fix:** Add `services.AddAntiforgery()` (already implicit) and `[ValidateAntiForgeryToken]` on POST handlers, plus the token field in forms.

**Effort:** 1h

---

## 5. Bugs & Correctness Issues

### 5.1 `BosKoltuk` Calculation Assumes One Ticket Per Seat

**File:** `StajWinForms_API/Controllers/SeferDetayController.cs:31`

```csharp
BosKoltuk = s.KoltukKapasitesi - s.Biletlers.Select(b => b.KoltukNo).Distinct().Count()
```

A seat sold twice on different legs (e.g., leg 1→2 and leg 3→4) is counted once as "occupied" even though it's actually available for the middle segment. This under-reports availability and blocks legitimate sales.

**Fix:** Calculate free seats **per leg** for the specific search, not globally per trip. Or, at minimum, document the limitation.

**Effort:** 2h

### 5.2 Hardcoded Account Protection

`KullanicilarController.cs:91,139` prevents delete/permission-change if `KullaniciAdi == "metehansarica"`. Fragile and undocumented.

**Fix:** Add `IsSystemAccount BIT` column to `Kullanicilar`. Set it on the seed admin. Check that flag instead of a hardcoded string.

**Effort:** 1h

### 5.3 Fire-and-Forget Task in WinForms

**File:** `StajWinForms/UserControls/MusteriKaydiControl.cs:31`

`_ = SehirleriYukle();` — if the API is down, the combo silently stays empty and the user sees no error.

**Fix:** Await it from an `async` `Load` event, or use `Task.Run(...).ContinueWith(HandleError, TaskScheduler.FromCurrentSynchronizationContext())`.

**Effort:** 30m

### 5.4 IDOR on `DELETE /api/biletler/{id}`

Anyone with the API key can delete any ticket without proving ownership.

**Fix:** Require TC in the delete body/query; verify the ticket's `MusteriTc == suppliedTc` before deleting. (Weak, but reasonable for MVP without full accounts.) Or gate behind admin JWT (see 3.6).

**Effort:** 1h

---

## 6. Nice-to-Have (Post-MVP)

- Rate limiting on `/api/auth/login` (e.g., `AspNetCoreRateLimit` — 5 attempts / 5 min per IP).
- EF Core migrations instead of `db/adminpanel_tablolar.sql`.
- `xUnit` test project for `Dogrulama.cs`, `SatinAlBilet` conflict scenarios, and login flow.
- Audit log table (who did what, when).
- Replace `PropertyNameCaseInsensitive = true` per-call with `services.ConfigureHttpJsonOptions(...)` at composition root.
- Delete `tmp_crashtest/` folder.
- Remove or archive old planning `.md` files (`PLAN_pazartesi_odevleri.md`, `2026-07-20.md`, `pazartesiyeodevler.txt`) that clutter the root.
- Add a GitHub Actions workflow for `dotnet build` + `dotnet test`.
- Configure query logging in Development to verify no N+1 patterns.

---

## 7. Top 15 Ranked by Impact × Ease

### Must Fix (P0 — blocks pilot deploy)

| # | Item | Effort | Impact |
|---|------|--------|--------|
| 1 | Remove secrets from repo, rotate API key | 2h | Critical |
| 2 | Replace MD5 with `PasswordHasher<T>` | 3h | Critical |
| 3 | Create `PersonelGosterDto` (hide salary) | 2h | Critical |
| 4 | Add data-annotation validation to all DTOs | 4h | High |
| 5 | Add CORS + security-headers middleware | 2h | High |
| 6 | Add server-side authorization on admin endpoints (JWT + `[HasYetki]`) | 6h | High |

### Should Fix (P1 — needed for a good MVP)

| # | Item | Effort | Impact |
|---|------|--------|--------|
| 7 | Create DTOs for `Firmalar`/`Sehirler`/`Otobusler`/`OtobusKaptan` | 3h | Medium |
| 8 | Add `ILogger<T>` and error logging in controllers | 2h | Medium |
| 9 | Audit all Web `GetFromJsonAsync<T>` calls for `?? new()` | 1h | Medium |
| 10 | Anti-forgery tokens on admin POST handlers | 1h | Medium |
| 11 | Session stores only user id; re-fetch permissions per request | 2h | Medium |

### Nice to Have (P2 — polish)

| # | Item | Effort | Impact |
|---|------|--------|--------|
| 12 | Fix `BosKoltuk` per-leg calculation | 2h | Low |
| 13 | Replace hardcoded `"metehansarica"` guard with `IsSystemAccount` column | 1h | Low |
| 14 | Centralize `JsonSerializerOptions` + duplicate WinForms models | 2h | Low |
| 15 | Add xUnit project covering `Dogrulama` + `SatinAlBilet` conflict | 3h | Low |

**Total P0:** ~19h
**Total P0+P1:** ~28h
**Total P0+P1+P2:** ~36h

---

## 8. Recommended Order of Work (4-Day Sprint)

### Day 1 — Security foundation
- Item 1 (secrets) — morning
- Item 2 (bcrypt migration) — afternoon
- Item 3 (PersonelDto) — end of day

### Day 2 — Input safety
- Item 4 (DTO validation) — full morning
- Item 5 (CORS + headers) — early afternoon
- Item 9 (null-safety audit) — late afternoon
- Item 10 (anti-forgery) — end of day

### Day 3 — Authorization
- Item 6 (JWT + `[HasYetki]`) — full day

### Day 4 — Polish + Test
- Item 7 (remaining DTOs) — morning
- Item 8 (logging) — early afternoon
- Item 11 (session hardening) — late afternoon
- Items 12–15 as time permits

After this sprint the project should be **~85% MVP-ready** and safe to deploy to a small pilot group (10–20 test users) behind HTTPS.

---

## 9. Definition of Done for MVP

- [X] No secrets in git; `appsettings.Example.json` documented in README.
- [X] All passwords stored as PBKDF2 (via `PasswordHasher<T>`); MD5 helper deleted.
- [X] All controllers return DTOs; no raw entities in responses. (FirmalarController, SehirlerController güncellendi; OtobuslerController zaten uygundu)
- [X] All DTOs have data-annotation validation; `[ApiController]` returns 400 on bad input.
- [X] CORS policy explicit; security headers set (X-Content-Type-Options, X-Frame-Options, Referrer-Policy).
- [ ] Admin endpoints require valid JWT with correct `Yetki` claim. (atlandı — kapsam dışı)
- [X] Structured logs written to file for warnings/errors in production. (BiletlerController 500, AuthController başarısız login loglanıyor)
- [X] All Web `GetFromJsonAsync` calls handle null response.
- [ ] Admin forms include anti-forgery tokens. (atlandı)
- [X] `tmp_crashtest/` removed; stale planning `.md` files archived under `docs/history/`.
- [X] `dotnet build` succeeds with zero warnings.
- [ ] Manual smoke test: guest can search, buy, cancel; admin can log in, add firma, revoke a permission (and it takes effect immediately).

### Ek tamamlananlar (plan sonrası)
- [X] BiletSorgula boş TC hatası düzeltildi (400 → kullanıcı dostu hata mesajı).
- [X] Kaptan email duplicate hatası düzeltildi (PersonelController Conflict 409 + web TempData).
- [X] SeferDetay sayfası kaldırıldı; koltuk seçimi Seferler sayfasında inline açılıyor.
- [X] WinForms MusteriKaydiControl fire-and-forget düzeltildi (Load event'e taşındı).
- [X] Session yenileme (4.6) atlandı — 11 dosya etkiliyor, scope dışı bırakıldı.
- [X] **Dashboard** eklendi (Web + WinForms): Toplam Bilet, Toplam Gelir, Toplam Sefer, En Popüler Güzergahlar. Web → Bootstrap kartlar + progress bar; WinForms → DevExpress TileControl + ChartControl (bar chart). API: `GET /api/istatistikler`.
- [X] **Sefer Yönetimi (Admin CRUD)** eklendi: `SeferBrowserForm` (liste + grid), `SeferEditForm` (ekle/düzenle). API: `POST /api/seferler`, `PUT /api/seferler/{id}`, `DELETE /api/seferler/{id}` (bilet varsa 409 engeli).
- [X] **Bilet Arama (Admin)** eklendi: `BiletAramaForm` — kalkış şehri, varış şehri, tarih filtresi. API: `GET /api/biletler/ara?kalkisId=&varisId=&tarih=`.
- [X] **Yolcu Listesi** eklendi: `YolcuListesiForm` — sefer bazlı yolcu listesi (koltuk no, ad soyad, TC, cinsiyet). Sefer Yönetimi ekranından açılıyor.
- [X] `AdminPanelForm`'a "Sefer Yönetimi" (`btnSeferBrowser`) ve "Bilet Arama" (`btnBiletArama`) butonları eklendi.
- [X] `YetkiAtamaForm._formAdlari`'na "Sefer Yönetimi" ve "Bilet Arama" yetki satırları eklendi.
- [X] **Web Bilet Arama (Admin)** eklendi: `BiletArama.cshtml` — kalkış/varış/tarih filtreli, DataTables tablosu. `Index.cshtml`'e kart eklendi.
- [X] **Web YetkiAtama genişletildi**: `FormAdlari`'na btnSeferBrowser, btnBiletArama, btnDashboard eklendi; "Tümünü Temizle" butonu ve "Yetkileri Kopyala" modal eklendi (`OnPostTemizleAsync`, `OnPostKopyalaAsync`).
- [X] **Web Sefer Yönetimi (Admin CRUD)** eklendi: `SeferYonetim.cshtml` — DataTables listesi, Ekle/Düzenle modal, Sil; `SeferDto` eksik alanlarla güncellendi. `Index.cshtml`'e kart eklendi.
- [X] `tmp_crashtest/` silindi; stale planning `.md` dosyaları `docs/history/` altına taşındı.
- [X] `dotnet build` sıfır hata ve sıfır uyarı (DevExpress lisans DX1000/DX1001 dışında).
- [X] **WinForms Sefer Yönetimi UI iyileştirmeleri**: SpinEdit'lerde virgül kaldırıldı, boş varsayılan değer (`AllowNullInput`), Firma/Kalkış/Varış ComboBox'ları dropdown-only (`DisableTextEditor`), Kalkış Zamanı tıklanınca takvim açılıyor (`ShowPopup`).
- [X] **WinForms Bilet Arama UI iyileştirmeleri**: Kalkış/Varış ComboBox'ları dropdown-only, Tarih tıklanınca takvim açılıyor.
- [X] Admin panel buton sırası düzenlendi (WinForms + Web): Dashboard → Sefer Yönetimi → Bilet Arama → Firmalar → Otobüsler → Kaptanlar → Eşlemeler → Kullanıcı/Yetki.
- [X] **Müşteri Yönetimi (Web Admin)** eklendi: `Musteriler.cshtml` — TC/ad soyad filtreli liste, Biletler modal (müşteri bilet geçmişi), Sil. API: `GET /api/musteri?ara=`, `GET /api/musteri/{id}/biletler`, `DELETE /api/musteri/{id}`. `MusteriDto`'ya Tc/Email/Telefon eklendi. `Index.cshtml`'e kart, `YetkiAtama`'ya `btnMusteriBrowser` eklendi.
- [X] **Dashboard Firma Gelir Dağılımı grafiği** eklendi: Web → Chart.js doughnut grafik; WinForms → DevExpress Pie chart (`chartPie`). API: `IstatistikDto`'ya `FirmaGelirler` listesi eklendi, firma bazında gelir + bilet sayısı hesaplanıyor.
- [X] **Otogar Yönetimi** eklendi: API → `OtogarlarController` (GET/POST/PUT/DELETE), `OtogarDto`/`OtogarCreateDto`. WinForms → `OtogarEditForm` (şehir dropdown, ad, adres, maskeli telefon) + `OtogarBrowserForm` (grid + ekle/düzenle/sil). `AdminPanelForm`'a `btnOtogarBrowser` eklendi. `YetkiAtamaForm` ve Web `YetkiAtama`'ya yetki satırı eklendi. Web → `Otogarlar.cshtml` DataTables listesi + Ekle/Düzenle modal + Sil. `Index.cshtml`'e kart eklendi.

---

## 10. Post-MVP / Production Hardening

- Rate limiting on login (`AspNetCoreRateLimit`).
- Application Insights or Sentry for error monitoring.
- Database encryption at rest.
- Automated backups.
- Load test concurrent seat purchases (target: 50 concurrent).
- Move to real SQL Server (not LocalDB).
- HTTPS certificate (Let's Encrypt).
- EF Core migrations replacing raw SQL seed.
- CI: build + test on push; deploy on tag.
- Add `/health` endpoint for uptime monitoring.
