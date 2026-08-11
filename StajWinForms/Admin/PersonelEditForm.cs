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
using System.Drawing.Text;
using StajWinForms.Dtos;

namespace StajWinForms.Admin
{
    public partial class PersonelEditForm : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        private PersonelDto? _mevcut;

        public PersonelEditForm()
        {
            InitializeComponent();
        }


        internal PersonelEditForm(PersonelDto personel) : this()
        {
            _mevcut = personel;
            Text = "Personel Düzenle";
        }

        private void PersonelEditForm_Load(object sender, EventArgs e)
        {
            dtIseGiris.MouseClick += (s, e) => dtIseGiris.ShowPopup();

            if (_mevcut != null)
            {
                txtAd.Text = _mevcut.Ad;
                txtSoyad.Text = _mevcut.Soyad;
                txtEmail.Text = _mevcut.Email ?? "";
                txtUnvan.Text = _mevcut.Unvan ?? "";
                spnMaas.Value = _mevcut.Maas.HasValue ? (decimal)_mevcut.Maas.Value : 0;
                if (_mevcut.IseGirisTarihi.HasValue)
                {
                    dtIseGiris.DateTime = _mevcut.IseGirisTarihi.Value.ToDateTime(TimeOnly.MinValue);
                }
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                XtraMessageBox.Show("Ad ve Soyad zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAd.Text.Trim().Length < 2 || txtSoyad.Text.Trim().Length < 2)
            {
                XtraMessageBox.Show("Ad ve soyad en az 2 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                XtraMessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateOnly? iseGiris = null;
            if (dtIseGiris.DateTime != DateTime.MinValue)
                iseGiris = DateOnly.FromDateTime(dtIseGiris.DateTime);

            var dto = new
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Unvan = string.IsNullOrWhiteSpace(txtUnvan.Text) ? null : txtUnvan.Text.Trim(),
                Maas = spnMaas.Value == 0 ? (decimal?)null : spnMaas.Value,
                IseGirisTarihi = iseGiris
            };

            HttpResponseMessage resp;
            if (_mevcut == null)
            {
                resp = await _http.PostAsJsonAsync("api/personel", dto);
            }
            else
            {
                resp = await _http.PutAsJsonAsync($"api/personel/{_mevcut.Id}", dto);
            }

            if (resp.IsSuccessStatusCode)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
