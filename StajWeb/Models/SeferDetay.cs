using Microsoft.AspNetCore.Mvc;

namespace StajWeb.Models
{
    public class SeferDetay
    {
        public int SeferId { get; set; }
        public string FirmaAdi { get; set; }
        public string KalkisSehirAdi { get; set; }
        public string VarisSehirAdi { get; set; }
        public DateTime KalkisZamani { get; set; }
        public decimal Fiyat { get; set; }
        public int BosKoltuk { get; set; }
        public List<string> Duraklar { get; set; }
        public int KalkisSehirId { get; set; }
        public int VarisSehirId { get; set; }
        public int Id { get; set; }
        

    }
}
