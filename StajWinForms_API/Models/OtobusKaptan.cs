using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class OtobusKaptan
{
    public int Id { get; set; }
    public int OtobusId { get; set; }
    public int PersonelId { get; set; }

    [JsonIgnore]
    public virtual Otobusler Otobus { get; set; } = null!;

    public virtual Personel Personel { get; set; } = null!;
}
