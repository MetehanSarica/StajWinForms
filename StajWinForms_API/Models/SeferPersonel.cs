using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class SeferPersonel
{
    public int Id { get; set; }

    public int SeferId { get; set; }

    public int PersonelId { get; set; }

    public string? Rol { get; set; }

    [JsonIgnore]
    public virtual Seferler Sefer { get; set; } = null!;

    [JsonIgnore]
    public virtual Personel Personel { get; set; } = null!;
}
