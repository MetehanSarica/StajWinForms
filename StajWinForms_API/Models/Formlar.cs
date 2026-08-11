namespace StajWinForms_API.Models
{
    public partial class Formlar
    {
        public int FormId { get; set; }
        public string FormAdi { get; set; } = null!;
        public string FormAciklamasi { get; set; } = null!;

        public virtual ICollection<KullaniciYetkileri> KullaniciYetkileri { get; set; } = new List<KullaniciYetkileri>();
    }
}
