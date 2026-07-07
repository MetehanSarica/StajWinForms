using StajWinForms_API.Models;

namespace StajWinForms_API.Dtos
{
    public class SeferDetayDto
    {
        public required string FirmaAdi { get; set; } = new Firmalar().FirmaAdi;

        public required string KalkisSehirAdi { get; set; } = new Sehirler().SehirAdi;

        public required string VarisSehirAdi { get; set; } = new Sehirler().SehirAdi;

        public required DateTime KalkisZamani { get; set; }

        public required decimal Fiyat { get; set; }

        public required int BosKoltuk { get; set; }
    }
}
