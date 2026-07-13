namespace StajWeb.Dtos
{
    public class BiletDto
    {
        public int BiletId { get; set; }
        public int KoltukNo { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string MusteriTc { get; set; }
        public string KalkisSehirAdi { get; set; }
        public string VarisSehirAdi { get; set; }
        public DateTime KalkisZamani { get; set; }
        public string FirmaAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Cinsiyet { get; set; }
    }
}
