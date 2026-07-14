namespace StajWinForms_API.Dtos
{
    public class SeferPersonelDto
    {
        public int Id { get; set; }
        public int SeferId { get; set; }
        public int PersonelId { get; set; }
        public string PersonelAdSoyad { get; set; } = "";
        public string? Rol { get; set; }
    }

    public class AtaPersonelDto
    {
        public required int SeferId { get; set; }
        public required int PersonelId { get; set; }
        public string? Rol { get; set; }
    }
}
