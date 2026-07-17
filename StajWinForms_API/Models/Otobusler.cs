using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class Otobusler
{
    public int OtobusId { get; set; }
    public string Plaka { get; set; } = null!;
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public int KoltukKapasitesi { get; set; } = 36;
    public int? FirmaId { get; set; }

    public virtual Firmalar? Firma { get; set; }

    [JsonIgnore]
    public virtual ICollection<OtobusKaptan> OtobusKaptanlar { get; set; } = new List<OtobusKaptan>();
}
