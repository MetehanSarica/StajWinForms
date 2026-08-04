using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace StajWeb.Dtos
{
    public class LoginDto
    {
        public string KullaniciAdi { get; set; } = null!;
        public string Sifre { get; set; }
    }

    public class LoginSonucDto
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set;} = null!; 
        public string? AdSoyad { get; set; }
        public List<KullaniciYetkiDto> Yetkiler { get; set; } = new();
    } 

    public class KullaniciYetkiDto
    {
        public string FormAdi { get; set; } = null!;
        public bool Ekle {  get; set; }
        public bool Sil {  get; set; }
        public bool Degistir { get; set; }
        public bool Incele { get; set; }
        public bool Ata {  get; set; }
        public bool Kaldir { get; set; }
        public bool Kaydet { get; set; }
    }

    public class FirmaDto
    {
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = "";
    }

    public class OtobusDto
    {
        public int OtobusId { get; set; }
        public string Plaka { get; set; } = "";
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public int KoltukKapasitesi { get; set; }
        public int? FirmaId { get; set; }
        public string? FirmaAdi { get; set; }
    }

    public class PersonelDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = "";
        public string Soyad { get; set; } = "";
        public string? Email { get; set; }
        public string? Unvan { get; set; }
        public decimal? Maas { get; set; }
        public DateOnly? IseGirisTarihi { get; set; }
    }

    public class KullaniciDto
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; } = "";
        public string? AdSoyad { get; set; }
        public bool Aktif { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
    }

    public class SeferDto
    {
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = "";
        public int KalkisSehirId { get; set; }
        public int VarisSehirId { get; set; }
        public int SureDakika { get; set; }
        public decimal Fiyat { get; set; }
        public int KoltukKapasitesi { get; set; }
        public int SeferId { get; set; }
        public string KalkisSehirAdi { get; set; } = "";
        public string VarisSehirAdi { get; set; } = "";
        public DateTime KalkisZamani { get; set; }
        public int? OtobusId { get; set; }
        public string? OtobusPlaka { get; set; }
    }

    public class OtobusKaptanDto
    {
        public int Id { get; set; }
        public int OtobusId { get; set; }
        public int PersonelId { get; set; }
        public string PersonelAdSoyad { get; set; } = "";
    }

}
