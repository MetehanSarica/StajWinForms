# Smoke Test Listesi
## StajWinForms — Manuel MVP Doğrulaması

---

## 1. API

- [X] `dotnet run` ile API ayağa kalkıyor
- [X] `GET /api/sehirler` → şehir listesi dönüyor
- [X] `GET /api/seferler` → sefer listesi dönüyor
- [X] `GET /api/istatistikler` → toplam bilet/gelir/sefer dönüyor

---

## 2. WinForms — Misafir Akışı

- [X] Uygulama açılıyor, login ekranı geliyor
- [X] Yanlış şifre → hata mesajı gösteriyor
- [X] Doğru şifre → ana menü açılıyor
- [X] Kalkış / varış şehri seçimi çalışıyor
- [X] Sefer listesi yükleniyor
- [X] Koltuk seçim ekranı açılıyor, dolu/boş koltuklar gösteriliyor
- [X] Müşteri bilgileri giriliyor, bilet satın alınıyor
- [X] PDF bilet üretiliyor ve açılıyor
- [X] Bilet sorgulama: TC ile sorgu → bilet bulunuyor
- [X] Bilet iptali: onay → bilet iptal ediliyor

---

## 3. WinForms — Admin Akışı

- [X] Admin hesabıyla login → Admin Paneli açılıyor
- [X] Yetki olmayan butonlar görünmüyor
- [X] **Dashboard**: 4 kart yükleniyor, bar chart gösteriliyor
- [X] **Firma Yönetimi**: liste geliyor, ekle/düzenle/sil çalışıyor
- [x] **Otobüs Yönetimi**: liste geliyor, ekle/sil çalışıyor
- [X] **Kaptan Yönetimi**: liste geliyor, ekle/sil çalışıyor
- [ ] **Sefer Yönetimi**: liste geliyor, ekle/düzenle/sil çalışıyor (Sefer Oluşturma Hatası çözüldü. textboxlar düzenlenecek(virgülleri kaldırılacak, 0 yerine varsayılan değeri boş olacak ), firma, kalkissehir ve varissehir dropdown şeklinde olacak, kalkis zamanina tiklaninca takvim acilacak)
- [X] **Sefer Yönetimi → Yolcular**: sefer seçilip Yolcular açılıyor, liste geliyor
- [ ] **Bilet Arama**: filtre seçilip arama yapılıyor, sonuçlar geliyor (comboboxlarda kalkis ve varis sehirlari dropdown seklinde menu acacak, tarih'e takvim olacak)
- [X] **Kullanıcı Yönetimi**: liste geliyor, ekle/düzenle/sil çalışıyor
- [X] **Yetki Atama**: kullanıcı seçilip yetkiler gösteriliyor, kaydediliyor
- [X] **Yetki Atama → Kopyala**: modal açılıyor, hedef seçilip kopyalanıyor
- [X] **Yetki Atama → Temizle**: onay sonrası yetkiler sıfırlanıyor
- [X] Çıkış → login ekranına dönüyor

---

## 4. Web — Misafir Akışı

- [x] Ana sayfa açılıyor
- [x] Kalkış / varış / tarih seçilip sefer aranıyor
- [X] Sefer listesi geliyor, koltuk seçim dropdown'ı açılıyor
- [X] Müşteri bilgileri girilerek bilet satın alınıyor
- [X] Bilet sorgulama sayfası: TC ile sorgu → bilet bulunuyor
- [X] Bilet iptali çalışıyor

---

## 5. Web — Admin Akışı

- [X] `/Admin/Login` ile giriş yapılıyor
- [X] Yetki olmayan kartlar görünmüyor 
- [X] **Dashboard**: istatistik kartları ve güzergah progress bar'ları yükleniyor
- [X] **Firmalar**: liste geliyor, ekle/düzenle/sil çalışıyor
- [X] **Sefer Yönetimi**: liste geliyor, ekle/düzenle/sil çalışıyor 
- [X] **Bilet Arama**: filtre uygulanıyor, sonuçlar DataTables'ta gösteriliyor
- [X] **Kullanıcı Yönetimi**: ekle/düzenle/sil çalışıyor
- [X] **Yetki Atama**: kullanıcı seçilip yetkiler gösteriliyor, kaydediliyor
- [X] **Yetki Atama → Temizle**: çalışıyor
- [X] **Yetki Atama → Kopyala**: modal açılıyor, hedef seçilip kopyalanıyor
- [X] Çıkış → login'e yönlendiriyor
- [X] Oturumu olmayan kullanıcı `/Admin/Firmalar`'a direkt girmeye çalışırsa → login'e yönlendiriyor

---

## 6. Eş Zamanlı Senaryo

- [X] Aynı koltuk için iki ayrı pencereden eş zamanlı satın alma → biri 409 alıyor, diğeri başarılı

---

*Tüm maddeler geçerse MVP deploy edilmeye hazır.*
