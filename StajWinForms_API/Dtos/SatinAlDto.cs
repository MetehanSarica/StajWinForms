namespace StajWinForms_API.Dtos
{
    public class SatinAlDto
    {
        public required string MusteriTc { get; set; } = null!;
        
        public required string MusteriAd { get; set; } = null!;

        public required string MusteriSoyad { get; set; } = null!;

        public required string MusteriMail { get; set; } = null!;

        public required string MusteriTelefon { get; set; } = null!;

        public required string MusteriSehir { get; set; } = null!;

        public required string MusteriAdres { get; set; } = null!;

        public required string MusteriCinsiyet { get; set; } = null!;

        public required int SeferId { get; set; }

        public required int KoltukNo { get; set; }

        public required int BinisDurakSira { get; set; }

        public required int InisDurakSira { get; set; }
    }
}
