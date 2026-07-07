namespace StajWinForms_API.Dtos
{
    public class CreateBiletDto
    {
        public required int SeferId { get; set; }
        public required int KoltukNo { get; set; }
        public required string MusteriTc { get; set; } = null!;
        public required int BinisDurakSira { get; set; }
        public required int InisDurakSira { get; set; }
    }
}