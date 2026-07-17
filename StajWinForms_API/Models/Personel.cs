using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StajWinForms_API.Models;

public partial class Personel
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? Email { get; set; }

    public decimal? Maas { get; set; }

    public DateOnly? IseGirisTarihi { get; set; }

    [JsonIgnore]
    public virtual ICollection<SeferPersonel> SeferPersonels { get; set; } = new List<SeferPersonel>();

    [JsonIgnore]
    public virtual ICollection<OtobusKaptan> OtobusKaptanlar { get; set; } = new List<OtobusKaptan>();
}
