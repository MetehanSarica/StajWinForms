namespace StajWeb.Dtos
{
    public class IstatistikDto
    {
        public int ToplamBilet { get; set; }
        public decimal ToplamGelir { get; set; }
        public int AktifSeferler {  get; set; }
        public List<GuzergahIstatistikDto> PopulerGuzergahlar { get; set; } = new();
    }

    public class GuzergahIstatistikDto
    {
        public string Guzergah { get; set; } = "";
        public int BiletSayisi { get; set; }
    }
}
