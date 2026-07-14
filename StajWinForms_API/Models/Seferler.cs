using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Seferler
{
    public int SeferId { get; set; }

    public int FirmaId { get; set; }

    public int KalkisSehirId { get; set; }

    public int VarisSehirId { get; set; }

    public DateTime KalkisZamani { get; set; }

    public int SureDakika { get; set; }

    public decimal Fiyat { get; set; }

    public int KoltukKapasitesi { get; set; }

    public int BosKoltuk { get; set; }

    public virtual ICollection<Biletler> Biletlers { get; set; } = new List<Biletler>();

    public virtual Firmalar Firma { get; set; } = null!;

    public virtual Sehirler KalkisSehir { get; set; } = null!;

    public virtual ICollection<SeferDuraklar> SeferDuraklars { get; set; } = new List<SeferDuraklar>();

    public virtual ICollection<SeferDurakOtogar> SeferDurakOtogars { get; set; } = new List<SeferDurakOtogar>();

    public virtual ICollection<SeferPersonel> SeferPersonels { get; set; } = new List<SeferPersonel>();

    public virtual Sehirler VarisSehir { get; set; } = null!;
}
