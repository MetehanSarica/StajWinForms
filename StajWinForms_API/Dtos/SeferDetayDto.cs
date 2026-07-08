namespace StajWinForms_API.Dtos
{
    public class SeferDetayDto
    {
        public required int SeferId { get; set; }
        public required string FirmaAdi { get; set; }
        public required string KalkisSehirAdi { get; set; }
        public required string VarisSehirAdi { get; set; }
        public required DateTime KalkisZamani { get; set; }
        public required decimal Fiyat { get; set; }
        public required int BosKoltuk { get; set; }
    }
}
