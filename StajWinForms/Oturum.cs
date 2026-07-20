namespace StajWinForms;

public static class Oturum
{
    public static int KullaniciId { get; set; }
    public static string KullaniciAdi { get; set; } = "";
    public static string AdSoyad { get; set; } = "";
    public static List<KullaniciYetkiDto> Yetkiler { get; set; } = new();
}
