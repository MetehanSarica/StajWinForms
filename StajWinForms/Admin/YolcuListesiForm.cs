using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;

namespace StajWinForms.Admin
{
    public partial class YolcuListesiForm : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        private readonly int _seferId;

        public YolcuListesiForm(int seferId, string guzergah)
        {
            InitializeComponent();
            _seferId = seferId;
            lblGuzerah.Text = guzergah;
        }

        private async void YolcuListesiForm_Load(object sender, EventArgs e)
        {
            var yolcular = await _http.GetFromJsonAsync<List<YolcuDto>>("api/biletler/" + _seferId, _opts) ?? new();
            gridYolcular.DataSource = yolcular;
        }

        record YolcuDto(int KoltukNo, string MusteriAdSoyad, string MusteriTc, string? Cinsiyet);
    }
}
