# StajWinForms — Otobüs Bilet Satış Sistemi

Staj projesi: WinForms (DevExpress) istemci + ASP.NET Core Web API ile otobüs bilet satış uygulaması.

## Yapı

- **StajWinForms/** — WinForms istemci (DevExpress kontrolleri). Sefer arama, koltuk seçimi (cinsiyete göre renklendirme), müşteri kaydı, bilet oluşturma (QuestPDF ile PDF bilet), bilet sorgulama ve iptal.
- **StajWinForms_API/** — ASP.NET Core Web API + Entity Framework Core (SQL Server LocalDB, `dbStaj` veritabanı).

## Çalıştırma

1. API'yi başlat: `dotnet run --project StajWinForms_API` (http://localhost:8081)
2. İstemciyi başlat: `dotnet run --project StajWinForms`

## Güvenlik Notu

`appsettings.json` dosyalarındaki `ApiKey` (`staj-2026-gizli-anahtar`) **demo amaçlıdır**.
Gerçek bir projede gizli anahtarlar repoya commit edilmemeli; bunun yerine
`dotnet user-secrets` (geliştirme) veya ortam değişkenleri (üretim) kullanılmalıdır.
