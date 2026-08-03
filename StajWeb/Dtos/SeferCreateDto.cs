namespace StajWeb.Dtos
{
    public class SeferCreateDto
    {
        public int FirmaId { get; set; }
        public int KalkisSehirId { get; set; }
        public int VarisSehirId { get; set; }
        public DateTime KalkisZamani { get; set; }
        public int SureDakika { get; set; }
        public decimal Fiyat { get; set; }
        public int KoltukKapasitesi { get; set; }
    }
}
