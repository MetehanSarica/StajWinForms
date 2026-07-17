using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class KullaniciYetkileri
{
    public int Id { get; set; }
    public int KullaniciId { get; set; }
    public int YetkiId { get; set; }

    [JsonIgnore]
    public virtual Kullanicilar Kullanici { get; set; } = null!;

    [JsonIgnore]
    public virtual Yetkiler Yetki { get; set; } = null!;
}
