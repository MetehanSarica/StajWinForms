namespace StajWeb.Dtos
{
    public class OtogarDto
    {
        public int OtogarId { get; set; }
        public int SehirId { get; set; }
        public string SehirAdi { get; set; } = "";
        public string OtogarAdi { get; set; } = "";
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
    }
}
