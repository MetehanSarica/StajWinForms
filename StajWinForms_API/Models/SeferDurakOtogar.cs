using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class SeferDurakOtogar
{
    public int Id { get; set; }

    public int SeferId { get; set; }

    public int OtogarId { get; set; }

    public int DurakSira { get; set; }

    public DateTime? GelisSaati { get; set; }

    public DateTime? GidisSaati { get; set; }

    public virtual Seferler Sefer { get; set; } = null!;

    public virtual Otogarlar Otogar { get; set; } = null!;
}
