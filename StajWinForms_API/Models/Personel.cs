using System;
using System.Collections.Generic;

namespace StajWinForms_API.Models;

public partial class Personel
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? Email { get; set; }

    public decimal? Maas { get; set; }

    public DateOnly? IseGirisTarihi { get; set; }
}
