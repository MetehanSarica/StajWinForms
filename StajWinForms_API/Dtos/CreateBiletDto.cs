using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos
{
    public class CreateBiletDto
    {
        [Range (1, int.MaxValue)]public required int SeferId { get; set; }
        [Range (1, 36)]public required int KoltukNo { get; set; }

        [Required, RegularExpression(@"^[1-9]\d{10}$", ErrorMessage = "TC 11 haneli olmalı, 0 ile başlayamaz")]
        public required string MusteriTc { get; set; } = null!;
        [Range(0, int.MaxValue)] public required int BinisDurakSira { get; set; }
        [Range(0, int.MaxValue)] public required int InisDurakSira { get; set; }

        [Required, RegularExpression(@"^[EK]$")]
        public required string Cinsiyet { get; set; } = null!;

    }
}