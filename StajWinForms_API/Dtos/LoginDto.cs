namespace StajWinForms_API.Dtos;

public class LoginDto
{
    public string KullaniciAdi { get; set; } = null!;
    public string Sifre { get; set; } = null!;
}

public class LoginSonucDto
{
    public int KullaniciId { get; set; }
    public string KullaniciAdi { get; set; } = null!;
    public string? AdSoyad { get; set; }
    public List<string> YetkiKodlari { get; set; } = new();
}
