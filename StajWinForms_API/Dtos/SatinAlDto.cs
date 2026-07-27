using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos
{
    public class SatinAlDto
    {

        [Required, RegularExpression(@"^[1-9]\d{10}$", ErrorMessage = "TC 11 haneli olmalı, 0 ile başlayamaz")]
        public required string MusteriTc { get; set; } = null!;

        [Required, StringLength(50, MinimumLength = 2)]
        public required string MusteriAd { get; set; } = null!;

        [Required, StringLength(50, MinimumLength = 2)]
        public required string MusteriSoyad { get; set; } = null!;
        
        [Required, EmailAddress]
        public required string MusteriMail { get; set; } = null!;
        
        [Required, RegularExpression(@"^0\d{10}$")]
        public required string MusteriTelefon { get; set; } = null!;

        public required string MusteriSehir { get; set; } = null!;

        public required string MusteriAdres { get; set; } = null!;

        [Required, RegularExpression(@"^[EK]$")]
        public required string MusteriCinsiyet { get; set; } = null!;

        [Range(1, int.MaxValue)] public required int SeferId { get; set; }

        [Range(1, 36)]public required int KoltukNo { get; set; }

        public required int BinisDurakSira { get; set; }

        public required int InisDurakSira { get; set; }
    }
}
