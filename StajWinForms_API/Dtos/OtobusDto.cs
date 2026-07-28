using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos;

public class OtobusDto
{
    public int OtobusId { get; set; }
    public string Plaka { get; set; } = null!;
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public int KoltukKapasitesi { get; set; }
    public int? FirmaId { get; set; }
    public string? FirmaAdi { get; set; }
}

public class OtobusOlusturDto
{
    [Required, RegularExpression(@"^\d{2}\s?[A-Z]{1,3}\s?\d{2,4}$", ErrorMessage = "Geçerli bir plaka giriniz (örn: 34 ABC 123)")]
    public string Plaka { get; set; } = null!;

    [StringLength(50)]
    public string? Marka { get; set; }

    [StringLength(50)]
    public string? Model { get; set; }

    [Range(1, 60)]
    public int KoltukKapasitesi { get; set; } = 36;

    [Range(1, int.MaxValue)]
    public int? FirmaId { get; set; }
}

public class OtobusKaptanDto
{
    public int Id { get; set; }
    public int OtobusId { get; set; }
    public int PersonelId { get; set; }
    public string? PersonelAdSoyad { get; set; }
}

public class FirmaDto
{
    public int FirmaId { get; set; }
    public string FirmaAdi { get; set; } = "";
}

public class SehirDto
{
    public int SehirId { get; set; }
    public string SehirAdi { get; set; } = "";
}