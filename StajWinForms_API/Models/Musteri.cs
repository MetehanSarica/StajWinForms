using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Musteri
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string? Sehir { get; set; }

    public string? Adres { get; set; }

    public DateOnly? KayitTarihi { get; set; }

    public string Tc { get; set; } = null!;

    public virtual ICollection<Biletler> Biletlers { get; set; } = new List<Biletler>();
}
