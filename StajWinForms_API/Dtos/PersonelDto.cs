using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos
{
    public record PersonelDto
    {
        public int Id { get; set; }
        [Required, StringLength(50, MinimumLength = 2)] public string Ad { get; set; } = "";
        [Required, StringLength(50, MinimumLength = 2)] public string Soyad { get; set; } = "";
        [EmailAddress, StringLength(100)] public string? Email { get; set; }
        [StringLength(50)] public string? Unvan { get; set; }
        [Range(0, 1000000)] public decimal? Maas { get; set; }
        public DateOnly? IseGirisTarihi { get; set; }
    }
}
