using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class Yetkiler
{
    public int YetkiId { get; set; }
    public string YetkiKodu { get; set; } = null!;
    public string YetkiAdi { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<KullaniciYetkileri> KullaniciYetkileri { get; set; } = new List<KullaniciYetkileri>();
}
