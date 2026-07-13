using DevExpress.XtraEditors;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class CokluMusteriKaydi : DevExpress.XtraEditors.XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private readonly List<MusteriKaydiControl> _controls = new();

        public CokluMusteriKaydi(List<int> koltuklar, int seferId, int binisSira, int inisSira)
        {
            InitializeComponent();

            Text = "Müşteri Kayıtları";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            var panel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            int yOffset = 10;
            foreach (var koltukNo in koltuklar)
            {
                try
                {
                    var control = new MusteriKaydiControl(seferId, koltukNo, binisSira, inisSira);
                    control.Location = new Point(10, yOffset);
                    panel.Controls.Add(control); 

                    if (_controls == null) _controls = new List<MusteriKaydiControl>();
                    _controls.Add(control);

                    yOffset += control.Height + 10;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koltuk {koltukNo} için ekran oluşturulurken bir hata oluştu:\n\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                        "UserControl Hatası Yakalandı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            var btnBiletOlustur = new SimpleButton
            {
                Text = "Biletleri Oluştur",
                Size = new Size(160, 36),
                Location = new Point((450 - 160) / 2, yOffset + 5)
            };
            btnBiletOlustur.Click += BtnBiletOlustur_Click;
            panel.Controls.Add(btnBiletOlustur);

            int screenHeight = Screen.PrimaryScreen?.WorkingArea.Height ?? 800;
            int formHeight = Math.Min(yOffset + 80, screenHeight - 100);
            ClientSize = new Size(450, formHeight);
            Controls.Add(panel);
        }

        private async void BtnBiletOlustur_Click(object? sender, EventArgs e)
        {
            foreach (var ctrl in _controls)
                if (!ctrl.Dogrula()) return;

            foreach (var ctrl in _controls)
            {
                var model = ctrl.GetModel();
                try
                {
                    var response = await _http.PostAsJsonAsync("api/biletler/satinal", model);
                    if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        var mesaj = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Koltuk {model.KoltukNo}: {mesaj}", "Koltuk Dolu",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Koltuk {model.KoltukNo}: Bilet oluşturulamadı.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Sunucuya ulaşılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Tüm biletler başarıyla oluşturuldu.", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
