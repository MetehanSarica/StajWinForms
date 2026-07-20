using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class KullaniciYetkileri
{
    public string FormAdi { get; set; } = null!;
    public int KullaniciId { get; set; }
    public bool Ekle { get; set; }
    public bool Sil { get; set; }
    public bool Degistir { get; set; }
    public bool Incele { get; set; }
    public bool Ata { get; set; }
    public bool Kaldir { get; set; }
    public bool Kaydet { get; set; }

    [JsonIgnore]
    public virtual Kullanicilar? Kullanici { get; set; }
}
