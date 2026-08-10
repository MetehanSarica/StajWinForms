using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.Json;
using DevExpress.Utils.MVVM;

namespace StajWinForms.Admin
{
    public partial class MusteriEditForm : XtraForm
    {
        private readonly MusteriBrowserControl.MusteriModel? _mevcut;
        private readonly bool _incele;
        public object? Sonuc { get; private set; }

        public MusteriEditForm()
        {
            InitializeComponent();
        }

        public MusteriEditForm(MusteriBrowserControl.MusteriModel m, bool incele = false) : this()
        {
            _mevcut = m;
            _incele = incele;
            Text = incele ? "Müşteri İncele" : "Müşteri Düzenle";
        }

        private void MusteriEditForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Properties.Items.AddRange(new[] { "Erkek", "Kadın" });
            if (_mevcut != null)
            {
                txtAd.Text = _mevcut.Ad;
                txtSoyad.Text = _mevcut.Soyad;
                txtTc.Text = _mevcut.Tc;
                txtEmail.Text = _mevcut.Email;
                txtTelefon.Text = _mevcut.Telefon;
                txtSehir.Text = _mevcut.Sehir ?? "";
                cmbCinsiyet.Text = _mevcut.Cinsiyet;
                if (_mevcut.KayitTarihi.HasValue)
                {
                    dtKayitTarihi.DateTime = _mevcut.KayitTarihi.Value.ToDateTime(TimeOnly.MinValue);
                }
            }

            if (_incele)
            {
                foreach (Control c in Controls)
                {
                    c.Enabled = false;
                    btnKaydet.Visible = false;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text)
                || string.IsNullOrWhiteSpace(txtTc.Text))
            {
                return;
            }
            Sonuc = new
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Tc = txtTc.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Sehir = string.IsNullOrWhiteSpace(txtSehir.Text) ? null : txtSehir.Text.Trim(),
                Cinsiyet = cmbCinsiyet.Text,
                KayitTarihi = DateOnly.FromDateTime(dtKayitTarihi.DateTime)
            };
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}