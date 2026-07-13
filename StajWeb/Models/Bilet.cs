namespace StajWeb.Models
{
    public class Bilet
    {
        public int BiletId { get; set; }
        public int KoltukNo { get; set; }
        public string MusteriTc { get; set; } = string.Empty;
        public string Cinsiyet { get; set; } = string.Empty;
        public int BinisDurakSira { get; set; }
        public int InisDurakSira { get; set; }
    }
}
