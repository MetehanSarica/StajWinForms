namespace StajWinForms
{
    public partial class SecimEkrani : Form
    {
        public SecimEkrani()
        {
            InitializeComponent();
        }

        private void otobus_Click(object sender, EventArgs e)
        {
        }

        private void SecimEkrani_Load(object sender, EventArgs e)
        {
            var siraliButonlar = this.Controls.OfType<Button>()
                                              .OrderBy(btn => btn.Location.X)
                                              .ThenBy(btn => btn.Location.Y)
                                              .ToList();

            int koltukNo = 1;

            foreach (var btn in siraliButonlar)
            {
                btn.Text = koltukNo.ToString();
                btn.Name = "koltuk" + koltukNo.ToString();
                koltukNo++;
            }
        }
    }
}
