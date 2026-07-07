namespace StajWinForms_API.Dtos
{
    public class CreateBiletDto
    {
        public int SeferId { get; set; }
        public int KoltukNo { get; set; }
        public string MusteriTc { get; set; } = null!;
        public int BinisDurakSira { get; set; }
        public int InisDurakSira { get; set; }
    }
}