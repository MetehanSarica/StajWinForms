using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos
{
    public class SeferlerDto
    {
        public required int FirmaId { get; set; }
        public required int KalkisSehirId { get; set; }
        public required int VarisSehirId { get; set; }
        public required int SeferId { get; set; }
        public required DateTime KalkisZamani { get; set; }
        public required decimal Fiyat { get; set; }
        public string FirmaAdi { get; set; } = "";
        public string KalkisSehirAdi { get; set; } = "";
        public string VarisSehirAdi { get; set; } = "";
        public int SureDakika { get; set; }
        public int KoltukKapasitesi { get; set; }
        public int? OtobusId { get; set; }
        public string? OtobusPlaka { get; set; }
        public bool Aktif {  get; set; }
    }

    public class SeferOtobusAtaDto
    {
        [Range(1, int.MaxValue)]
        public int OtobusId { get; set; }
    }

    public class SeferCreateDto
    {
        [Range(1, int.MaxValue)] public int FirmaId { get; set; }
        [Range(1, int.MaxValue)] public int KalkisSehirId { get; set; }
        [Range(1, int.MaxValue)] public int VarisSehirId { get; set; }
        public DateTime KalkisZamani { get; set; }
        [Range(1, 1440)] public int SureDakika { get; set; }
        [Range(0.01, 100000)] public decimal Fiyat { get; set; }
        [Range(1, 60)] public int KoltukKapasitesi { get; set; }
    }
}
