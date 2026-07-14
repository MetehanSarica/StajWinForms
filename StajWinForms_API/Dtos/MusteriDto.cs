namespace StajWinForms_API.Dtos;

public record MusteriDto(
    int Id,
    string Ad,
    string Soyad,
    string? Sehir,
    string Cinsiyet,
    DateOnly? KayitTarihi
);
