using System.ComponentModel.DataAnnotations;

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
    [Required, StringLength(50, MinimumLength = 3)]
    public string KullaniciAdi { get; set; } = null!;

    [Required, StringLength(100, MinimumLength = 4)]
    public string Sifre { get; set; } = null!;

    [StringLength(100)]
    public string? AdSoyad { get; set; }

    public bool Aktif { get; set; } = true;
}

public class KullaniciGuncelleDto
{
    [Required, StringLength(50, MinimumLength = 3)]
    public string KullaniciAdi { get; set; } = null!;

    [StringLength(100, MinimumLength = 4)]
    public string? YeniSifre { get; set; }

    [StringLength(100)]
    public string? AdSoyad { get; set; }

    public bool Aktif { get; set; } = true;
}
