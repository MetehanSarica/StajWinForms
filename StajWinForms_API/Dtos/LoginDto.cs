using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos;

public class LoginDto
{
    [Required, StringLength(50, MinimumLength = 3)]
    public string KullaniciAdi { get; set; } = null!;

    [Required, StringLength(100, MinimumLength = 4)]
    public string Sifre { get; set; } = null!;
}

public class LoginSonucDto
{
    public int KullaniciId { get; set; }
    public string KullaniciAdi { get; set; } = null!;
    public string? AdSoyad { get; set; }
    public List<KullaniciYetkiDto> Yetkiler { get; set; } = new();
}

public class KullaniciYetkiDto
{
    [Required, StringLength(100)]
    public string FormAdi { get; set; } = null!;
    public bool Ekle {  get; set; }
    public bool Sil {  get; set; }
    public  bool Degistir { get; set; }
    public bool Incele { get; set; }
    public bool Ata {  get; set; }
    public  bool Kaldir { get; set; }
    public bool Kaydet { get; set; }
    public bool AktifPasif { get; set; }
}
