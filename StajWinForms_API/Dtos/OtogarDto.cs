using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos
{
    public class OtogarDto
    {
        public int OtogarId { get; set; }
        public int SehirId { get; set; }
        public string SehirAdi { get; set; } = "";
        public string OtogarAdi { get; set; } = "";
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
    }

    public class OtogarCreateDto
    {
        [Range(1, int.MaxValue)] public int SehirId { get; set; }
        [Required, StringLength(100, MinimumLength = 2)]public string OtogarAdi { get; set; } = "";
        [StringLength(200)]public string? Adres { get; set; }
        [RegularExpression(@"^0\d{10}$")]public string? Telefon { get; set; }
    }
}