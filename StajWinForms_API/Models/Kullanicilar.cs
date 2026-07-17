using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class Kullanicilar
{
    public int KullaniciId { get; set; }
    public string KullaniciAdi { get; set; } = null!;

    [JsonIgnore]
    public string SifreMd5 { get; set; } = null!;

    public string? AdSoyad { get; set; }
    public bool Aktif { get; set; } = true;
    public DateTime OlusturmaTarihi { get; set; }

    [JsonIgnore]
    public virtual ICollection<KullaniciYetkileri> KullaniciYetkileri { get; set; } = new List<KullaniciYetkileri>();
}
