using DevExpress.Data.ExpressionEditor;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class SecimEkrani : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };

        private readonly int _seferID;
        private List<int> _secilenKoltuklar = new();
        private int _binisSira;
        private int _inisSira;

        public SecimEkrani(int seferID)
        {
            _seferID = seferID;
            InitializeComponent();
            lblDuraklar.Properties.ReadOnly = true;
            lblDuraklar.Properties.AllowFocused = false;
            lblDuraklar.TabStop = false;
        }

        private async void SecimEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                KoltuklariNumaralandir();
                await DuraklariYukle();
                await KoltuklariRenklendir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme hatası:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KoltuklariNumaralandir()
        {
            var siraliButonlar = this.Controls.OfType<SimpleButton>()
                .Where(btn => btn.Name != "btnKoltukSec")
                .OrderBy(btn => btn.Location.X)
                .ThenBy(btn => btn.Location.Y)
                .ToList();

            int koltukNo = 1;
            foreach (var btn in siraliButonlar)
            {
                btn.Text = koltukNo.ToString();
                btn.Name = "koltuk" + koltukNo;
                btn.Click += KoltukButonu_Click;
                koltukNo++;
            }
        }

        private async System.Threading.Tasks.Task DuraklariYukle()
        {
            var json = await _http.GetStringAsync($"/api/seferduraklar/{_seferID}");
            var duraklar = JsonSerializer.Deserialize<List<SeferDurakApiModel>>(json, _jsonOpts) ?? new();

            if (duraklar.Count > 0)
            {
                _binisSira = duraklar.First().DurakSira;
                _inisSira = duraklar.Last().DurakSira;
            }

            string guzergah = "Güzergah: \r\n->" + string.Join("\r\n->", duraklar.Select(d => $"{d.OtogarAdi} ({d.SehirAdi})"));
            lblDuraklar.Text = guzergah;
        }

        private async System.Threading.Tasks.Task KoltuklariRenklendir()
        {
            var doluKoltuklar = await TumDoluKoltuklariGetir();
            _secilenKoltuklar.Clear();

            foreach (var btn in KoltukButonlari())
            {
                int no = int.Parse(btn.Text);
                doluKoltuklar.TryGetValue(no, out var cinsiyet);
                if (cinsiyet == "E")
                    KoltukRenkAyarla(btn, Color.LightBlue, true);
                else if (cinsiyet == "K")
                    KoltukRenkAyarla(btn, Color.LightPink, true);
                else
                    KoltukRenkAyarla(btn, Color.LightGreen, false);
            }
        }

        private async System.Threading.Tasks.Task<Dictionary<int, string>> TumDoluKoltuklariGetir()
        {
            var json = await _http.GetStringAsync($"/api/biletler/{_seferID}");
            var biletler = JsonSerializer.Deserialize<List<BiletApiModel>>(json, _jsonOpts) ?? new();
            return biletler.ToDictionary(b => b.KoltukNo, b => b.Cinsiyet ?? "");
        }

        private void KoltukButonu_Click(object? sender, EventArgs e)
        {
            if (sender is not SimpleButton btn)
                return;

            int no = int.Parse(btn.Text);
            if (_secilenKoltuklar.Contains(no))
            {
                _secilenKoltuklar.Remove(no);
                KoltukRenkAyarla(btn, Color.LightGreen, false);
            }
            else
            {
                _secilenKoltuklar.Add(no);
                KoltukRenkAyarla(btn, Color.Yellow, false);
            }
        }

        private async void btnKoltukSec_Click(object sender, EventArgs e)
        {
            try
            {
                if (_secilenKoltuklar == null || !_secilenKoltuklar.Any())
                {
                    MessageBox.Show("Lütfen önce bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var form = new CokluMusteriKaydi(_secilenKoltuklar, _seferID, _binisSira, _inisSira);
                form.ShowDialog(this);
                await KoltuklariRenklendir();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlem sırasında bir hata oluştu:\n\nHata Mesajı: {ex.Message}\n\nDetay:\n{ex.StackTrace}",
                    "Kritik Hata Yakalandı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static void KoltukRenkAyarla(SimpleButton btn, Color renk, bool disabled)
        {
            btn.LookAndFeel.UseDefaultLookAndFeel = false;
            btn.LookAndFeel.Style = LookAndFeelStyle.Flat;
            btn.Appearance.BackColor  = renk;
            btn.Appearance.BackColor2 = renk;
            btn.Appearance.Options.UseBackColor = true;
            btn.AppearanceDisabled.BackColor  = renk;
            btn.AppearanceDisabled.BackColor2 = renk;
            btn.AppearanceDisabled.Options.UseBackColor = true;
            btn.Enabled = !disabled;
        }

        private IEnumerable<SimpleButton> KoltukButonlari() =>
            this.Controls.OfType<SimpleButton>().Where(b => b.Name.StartsWith("koltuk"));
    }

    internal class SeferDurakApiModel
    {
        public int DurakSira { get; set; }
        public string SehirAdi { get; set; } = "";
        public string OtogarAdi { get; set; } = "";
    }

    internal class BiletApiModel
    {
        public int KoltukNo { get; set; }
        public string? Cinsiyet { get; set; }
        public int BinisDurakSira { get; set; }
        public int InisDurakSira { get; set; }
    }
}
