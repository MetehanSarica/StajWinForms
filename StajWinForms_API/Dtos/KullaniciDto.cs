namespace StajWinForms_API.Dtos;

public class KullaniciGosterDto
{
    public int KullaniciId { get; set; }
    public string KullaniciAdi { get; set; } = null!;
    public string? AdSoyad { get; set; }
    public bool Aktif { get; set; }
    public DateTime OlusturmaTarihi { get; set; }
}

public class KullaniciOlusturDto
{
    public string KullaniciAdi { get; set; } = null!;
    public string Sifre { get; set; } = null!;
    public string? AdSoyad { get; set; }
    public bool Aktif { get; set; } = true;
}

public class KullaniciGuncelleDto
{
    public string KullaniciAdi { get; set; } = null!;
    public string? YeniSifre { get; set; }
    public string? AdSoyad { get; set; }
    public bool Aktif { get; set; } = true;
}
