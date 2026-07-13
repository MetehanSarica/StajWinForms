namespace StajWinForms_API.Models
{
    public class SeferDetay
    {
        public virtual Firmalar Firma { get; set; } = new Firmalar();

        public virtual Sehirler KalkisSehir { get; set; } = null!;

        public virtual Sehirler VarisSehir { get; set; } = null!;

        public DateTime KalkisZamani { get; set; }

        public decimal Fiyat { get; set; }

        public int BosKoltuk { get; set; }


    }
}
