using System.ComponentModel.DataAnnotations;

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
        [Range(1, int.MaxValue)] public required int SeferId { get; set; }
        [Range(1, int.MaxValue)] public required int PersonelId { get; set; }
        [StringLength(50)] public string? Rol { get; set; }
    }
}
