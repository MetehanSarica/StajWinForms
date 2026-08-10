namespace StajWeb.Dtos
{
    public class BiletDetayDto
    {
        public int BiletId { get; set; }
        public int KoltukNo { get; set; }
        public int SeferId { get; set; }
        public string MusteriAd {  get; set; } = "";
        public string MusteriSoyad { get; set; } = "";
        public string MusteriTc {  get; set; } = "";
        public string MusteriTelefon { get; set; } = "";
        public string MusteriEmail { get; set; } = "";
        public string MusteriSehir { get; set; } = "";
        public string MusteriAdres { get; set; } = "";
        public string Cinsiyet { get; set; } = "";
        public string KalkisSehirAdi { get; set; } = "";
        public string VarisSehirAdi { get; set; } = "";
        public DateTime KalkisZamani { get; set; }
        public string FirmaAdi { get; set; } = "";
        public decimal Fiyat {  get; set; }
        public DateTime SatinAlmaTarihi { get; set; }
    }
}
