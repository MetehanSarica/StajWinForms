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
    public string Plaka { get; set; } = null!;
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public int KoltukKapasitesi { get; set; } = 36;
    public int? FirmaId { get; set; }
}

public class OtobusKaptanDto
{
    public int Id { get; set; }
    public int OtobusId { get; set; }
    public int PersonelId { get; set; }
    public string PersonelAdSoyad { get; set; } = null!;
}
