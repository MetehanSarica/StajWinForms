using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Otogarlar
{
    public int OtogarId { get; set; }

    public int SehirId { get; set; }

    public string OtogarAdi { get; set; } = null!;

    public string? Adres { get; set; }

    public string? Telefon { get; set; }

    public virtual Sehirler Sehir { get; set; } = null!;

    public virtual ICollection<SeferDurakOtogar> SeferDurakOtogars { get; set; } = new List<SeferDurakOtogar>();
}
