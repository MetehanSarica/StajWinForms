namespace StajWeb.Dtos
{
    public record MusteriDto(
        int Id,
        string Ad,
        string Soyad,
        string Tc,
        string? Email,
        string? Telefon,
        string? Sehir,
        string Cinsiyet,
        DateOnly? KayitTarihi
        );
}
