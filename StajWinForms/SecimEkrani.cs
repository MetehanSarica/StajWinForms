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
        private object? _oncekiBinisDuragi;
        private object? _oncekiInisDuragi;

        public SecimEkrani(int seferID)
        {
            _seferID = seferID;
            InitializeComponent();
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

        private async void cmbBinis_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbBinis.EditValue != null && cmbInis.EditValue != null)
            {
                int binisSira = Convert.ToInt32(cmbBinis.EditValue);
                int inisSira  = Convert.ToInt32(cmbInis.EditValue);
                if (binisSira >= inisSira)
                {
                    MessageBox.Show("Biniş durağı iniş durağından önce olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbBinis.EditValue = _oncekiBinisDuragi;
                    return;
                }
            }

            _oncekiBinisDuragi = cmbBinis.EditValue;
            try
            {
                await KoltuklariRenklendir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koltuk bilgileri güncellenemedi: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cmbInis_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbBinis.EditValue != null && cmbInis.EditValue != null)
            {
                int binisSira = Convert.ToInt32(cmbBinis.EditValue);
                int inisSira  = Convert.ToInt32(cmbInis.EditValue);
                if (binisSira >= inisSira)
                {
                    MessageBox.Show("İniş durağı biniş durağından sonra olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbInis.EditValue = _oncekiInisDuragi;
                    return;
                }
            }

            _oncekiInisDuragi = cmbInis.EditValue;
            try
            {
                await KoltuklariRenklendir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koltuk bilgileri güncellenemedi: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async System.Threading.Tasks.Task DuraklariYukle()
        {
            var json = await _http.GetStringAsync($"/api/seferduraklar/{_seferID}");
            var duraklar = JsonSerializer.Deserialize<List<SeferDurakApiModel>>(json, _jsonOpts) ?? new();

            cmbBinis.Properties.DataSource = duraklar.Select(d => new { d.DurakSira, d.SehirAdi }).ToList();
            cmbBinis.Properties.DisplayMember = "SehirAdi";
            cmbBinis.Properties.ValueMember = "DurakSira";

            cmbInis.Properties.DataSource = duraklar.Select(d => new { d.DurakSira, d.SehirAdi }).ToList();
            cmbInis.Properties.DisplayMember = "SehirAdi";
            cmbInis.Properties.ValueMember = "DurakSira";

            if (duraklar.Count > 0)
            {
                cmbBinis.EditValue = duraklar.First().DurakSira;
                _oncekiBinisDuragi = cmbBinis.EditValue;
            }

            if (duraklar.Count > 0)
            {
                cmbInis.EditValue = duraklar.Last().DurakSira;
                _oncekiInisDuragi = cmbInis.EditValue;
            }
        }

        private async System.Threading.Tasks.Task KoltuklariRenklendir()
        {
            Dictionary<int, string> doluKoltuklar;

            if (cmbBinis.EditValue != null && cmbInis.EditValue != null)
            {
                int binisSira = Convert.ToInt32(cmbBinis.EditValue);
                int inisSira  = Convert.ToInt32(cmbInis.EditValue);
                if (binisSira >= inisSira) return;
                doluKoltuklar = await DoluKoltuklariGetir(binisSira, inisSira);
            }
            else
            {
                doluKoltuklar = await TumDoluKoltuklariGetir();
            }

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

        private async System.Threading.Tasks.Task<Dictionary<int, string>> DoluKoltuklariGetir(int binisSira, int inisSira)
        {
            var json = await _http.GetStringAsync($"/api/biletler/{_seferID}");
            var biletler = JsonSerializer.Deserialize<List<BiletApiModel>>(json, _jsonOpts) ?? new();
            return biletler
                .Where(b => b.BinisDurakSira < inisSira && b.InisDurakSira > binisSira)
                .ToDictionary(b => b.KoltukNo, b => b.Cinsiyet ?? "");
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

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            if (_secilenKoltuklar == null || !_secilenKoltuklar.Any())
            {
                MessageBox.Show("Lütfen önce bir koltuk seçin.");
                return;
            }

            int acikFormSayisi = _secilenKoltuklar.Count;

            foreach (var no in _secilenKoltuklar)
                {
                    int binisSira = cmbBinis.EditValue != null ? Convert.ToInt32(cmbBinis.EditValue) : 0;
                    int inisSira  = cmbInis.EditValue  != null ? Convert.ToInt32(cmbInis.EditValue)  : 0;
                    MusteriKaydi musteriKaydi = new MusteriKaydi(_seferID, no, binisSira, inisSira);
                    musteriKaydi.FormClosed += async (s, args) =>
                    {
                        try
                        {
                            if (--acikFormSayisi == 0)
                                await KoltuklariRenklendir();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Koltuk bilgileri güncellenemedi: " + ex.Message, "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    musteriKaydi.Show();
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
    }

    internal class BiletApiModel
    {
        public int KoltukNo { get; set; }
        public string? Cinsiyet { get; set; }
        public int BinisDurakSira { get; set; }
        public int InisDurakSira { get; set; }
    }
}
