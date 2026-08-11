using DevExpress.XtraEditors;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using StajWinForms.Dtos;

namespace StajWinForms.Admin
{
    public partial class PersonelBrowserControl : UserControl
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        public PersonelBrowserControl() { InitializeComponent(); }

        private async void PersonelBrowserControl_Load(object sender, EventArgs e)
            => await PersonelleriYukle();

        private async Task PersonelleriYukle()
        {
            var liste = await _http.GetFromJsonAsync<List<PersonelDto>>("api/personel", _opts) ?? new();
            gridPersonel.DataSource = liste;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using var frm = new PersonelEditForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = PersonelleriYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var p = (PersonelDto)gridView.GetFocusedRow();
            using var frm = new PersonelEditForm(p);
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = PersonelleriYukle();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var p = (PersonelDto)gridView.GetFocusedRow();
            var onay = XtraMessageBox.Show($"{p.Ad} {p.Soyad} silinsin mi?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            var resp = await _http.DeleteAsync($"api/personel/{p.Id}");
            if (resp.IsSuccessStatusCode)
                await PersonelleriYukle();
            else
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btnYenile_Click(object sender, EventArgs e)
            => await PersonelleriYukle();
    }
}
