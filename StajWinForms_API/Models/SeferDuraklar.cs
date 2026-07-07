using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class SeferDuraklar
{
    public int SeferId { get; set; }

    public int DurakSira { get; set; }

    public int SehirId { get; set; }

    public DateTime GelisSaati { get; set; }

    public virtual Seferler Sefer { get; set; } = null!;

    public virtual Sehirler Sehir { get; set; } = null!;
}
