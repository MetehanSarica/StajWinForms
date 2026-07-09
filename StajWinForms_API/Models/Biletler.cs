using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Biletler
{
    public int BiletId { get; set; }

    public int SeferId { get; set; }

    public int KoltukNo { get; set; }

    public string MusteriTc { get; set; } = null!;

    public int BinisDurakSira { get; set; }

    public int InisDurakSira { get; set; }

    public string? Cinsiyet { get; set; }

    public virtual Musteri MusteriTcNavigation { get; set; } = null!;

    public virtual Seferler Sefer { get; set; } = null!;
}
