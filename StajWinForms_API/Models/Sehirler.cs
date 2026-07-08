using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Sehirler
{
    public int SehirId { get; set; }

    public string SehirAdi { get; set; } = null!;

    public int PlakaKodu { get; set; }

    public virtual ICollection<SeferDuraklar> SeferDuraklars { get; set; } = new List<SeferDuraklar>();

    public virtual ICollection<Otogarlar> Otogarlars { get; set; } = new List<Otogarlar>();

    public virtual ICollection<Seferler> SeferlerKalkisSehirs { get; set; } = new List<Seferler>();

    public virtual ICollection<Seferler> SeferlerVarisSehirs { get; set; } = new List<Seferler>();
}
