namespace StajWinForms_API.Dtos
{
    public class BiletDto
    {
        public required int BiletId { get; set; }
        public required int KoltukNo { get; set; }
        public required string MusteriAdSoyad { get; set; } = null!;
        public required string MusteriTc { get; set; } = null!;
        public required int SeferId { get; set; }
        public required string KalkisSehirAdi { get; set; } = null!;
        public required string VarisSehirAdi { get; set; } = null!;
        public required DateTime KalkisZamani { get; set; }
        public string? Cinsiyet { get; set; }
        public int BinisDurakSira { get; set; }
        public int InisDurakSira { get; set; }
    }
}
