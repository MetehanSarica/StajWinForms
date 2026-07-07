using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Firmalar
{
    public int FirmaId { get; set; }

    public string FirmaAdi { get; set; } = null!;

    public virtual ICollection<Seferler> Seferlers { get; set; } = new List<Seferler>();
}
