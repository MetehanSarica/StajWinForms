namespace StajWinForms_API.Dtos
{
    public class BiletDto
    {
        public int BiletId { get; set; }
        public int KoltukNo { get; set; }
        public string? MusteriAdSoyad { get; set; }
        public string MusteriTc { get; set; } = null!;
        public int SeferId { get; set; }
        public string KalkisSehirAdi { get; set; } = null!;
        public string VarisSehirAdi { get; set; } = null!;
        public DateTime KalkisZamani { get; set; }
    }
}
