using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Firmalar
{
    public int FirmaId { get; set; } = 0;

    public string FirmaAdi { get; set; } = "";

    public virtual ICollection<Seferler> Seferlers { get; set; } = new List<Seferler>();
}
