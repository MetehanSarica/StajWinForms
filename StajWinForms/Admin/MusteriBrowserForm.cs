using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms.Admin
{
    public partial class MusteriBrowserForm : XtraForm
    {
        private static readonly JsonSerializerOptions _Opts = new() { PropertyNameCaseInsensitive = true };
        private List<MusteriModel> _musteriler = new();

        public MusteriBrowserForm()
        {
            InitializeComponent();
        }

        private async void MusteriBrowserForm_Load(object sender, EventArgs e)
        {
            await VeriYukle();
            var y = Oturum.Yetkiler.FirstOrDefault(x => x.FormAdi == "btnMusteriBrowser");
            if (y != null)
            {
                btnEkle.Visible = y.Ekle;
                btnDuzenle.Visible = y.Degistir;
                btnIncele.Visible = y.Incele;
                btnSil.Visible = y.Sil;
            }
        }

        private async Task VeriYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/musteri");
                _musteriler = JsonSerializer.Deserialize<List<MusteriModel>>(json, _Opts) ?? new();
                gridMusteriler.DataSource = null;
                gridMusteriler.DataSource = _musteriler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var dlg = new MusteriEditForm();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            var resp = await AppConfig.Http.PostAsJsonAsync("api/musteri", dlg.Sonuc);
            if (!resp.IsSuccessStatusCode)
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            await VeriYukle();
        }

        private async void btnDuzenle_Click(object sender, EventArgs e)
        {
            var val = gridView.GetFocusedRowCellValue("Id");
            if (val == null || val == DBNull.Value) return;
            var m = _musteriler.FirstOrDefault(x => x.Id == Convert.ToInt32(val));
            if (m == null) return;
            var dlg = new MusteriEditForm(m);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            var resp = await AppConfig.Http.PutAsJsonAsync($"api/musteri/{m.Id}", dlg.Sonuc);
            if (!resp.IsSuccessStatusCode)
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            await VeriYukle();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            var val = gridView.GetFocusedRowCellValue("Id");
            if (val == null || val == DBNull.Value) return;
            var m = _musteriler.FirstOrDefault(x => x.Id == Convert.ToInt32(val));
            if (m == null) return;
            var dlg = new MusteriEditForm(m);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            var resp = await AppConfig.Http.DeleteAsync($"api/musteri/{m.Id}");
            if (!resp.IsSuccessStatusCode)
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            await VeriYukle();
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            var val = gridView.GetFocusedRowCellValue("Id");
            if (val == null || val == DBNull.Value) return;
            var m = _musteriler.FirstOrDefault(x => x.Id == Convert.ToInt32(val));
            if (m == null) return;
            new MusteriEditForm(m, incele: true).ShowDialog();
        }

        private async void btnYenile_Click(object sender, EventArgs e) => await VeriYukle();

        public class MusteriModel
        {
            public int Id { get; set; }
            public string Ad { get; set; } = "";
            public string Soyad { get; set; } = "";
            public string Tc { get; set; } = "";
            public string Email { get; set; } = "";
            public string Telefon { get; set; } = "";
            public string? Sehir { get; set; }
            public string Cinsiyet { get; set; } = "";
            public DateOnly? KayitTarihi { get; set; }
        }
    }
}