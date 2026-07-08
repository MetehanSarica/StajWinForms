using DevExpress.XtraEditors;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class MusteriKaydi : XtraForm
    {
        private readonly int _seferID;
        private readonly int _koltukNo;
        private readonly int _binisDurakSira;
        private readonly int _inisDurakSira;

        public MusteriKaydi(int seferID, int koltukNo, int binisDurakSira, int inisDurakSira)
        {
            _seferID = seferID;
            _koltukNo = koltukNo;
            _binisDurakSira = binisDurakSira;
            _inisDurakSira = inisDurakSira;
            InitializeComponent();
            lblKoltukBilgi.Text = $"Seçilen Koltuk: {_koltukNo}";
        }

        private bool Dogrula()
        {
            if (txtboxTC.Text.Trim().Length == 0 ||
                txtboxAd.Text.Trim().Length == 0 ||
                txtboxSoyad.Text.Trim().Length == 0 ||
                txtboxEmail.Text.Trim().Length == 0 ||
                txtboxTelefon.Text.Trim().Length == 0 ||
                txtboxSehir.Text.Trim().Length == 0 ||
                txtboxAdres.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string tc = txtboxTC.Text.Trim();
            if (tc.Length != 11 || tc[0] == '0')
            {
                MessageBox.Show("TC Kimlik No 11 haneli olmalı ve 0 ile başlamamalıdır.", "Geçersiz TC",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string telefon = txtboxTelefon.Text.Trim();
            if (telefon[0] == '0')
            {
                MessageBox.Show("Telefon numarası 0 ile başlamamalıdır.", "Geçersiz Telefon",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxTelefon.Text = "";
                return false;
            }

            return true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!Dogrula()) return;

            string tc = txtboxTC.Text.Trim();

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string query = @"INSERT INTO Musteri (TC, Ad, Soyad, Email, Telefon, Sehir, Adres)
                               VALUES (@TC, @Ad, @Soyad, @Email, @Telefon, @Sehir, @Adres)";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TC", tc);
                cmd.Parameters.AddWithValue("@Ad", txtboxAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtboxSoyad.Text);
                cmd.Parameters.AddWithValue("@Email", txtboxEmail.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtboxTelefon.Text);
                cmd.Parameters.AddWithValue("@Sehir", txtboxSehir.Text);
                cmd.Parameters.AddWithValue("@Adres", txtboxAdres.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Müşteri kaydı başarıyla eklendi.");
                this.Close();
            }
        }

        private void btnBiletOlustur_Click(object sender, EventArgs e)
        {
            if (!Dogrula()) return;

            string tc = txtboxTC.Text.Trim();

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();

                string musteriQuery = @"
                    IF NOT EXISTS (SELECT 1 FROM Musteri WHERE TC = @TC)
                        INSERT INTO Musteri (TC, Ad, Soyad, Email, Telefon, Sehir, Adres)
                        VALUES (@TC, @Ad, @Soyad, @Email, @Telefon, @Sehir, @Adres)";
                SqlCommand musteriCmd = new SqlCommand(musteriQuery, conn);
                musteriCmd.Parameters.AddWithValue("@TC", tc);
                musteriCmd.Parameters.AddWithValue("@Ad", txtboxAd.Text);
                musteriCmd.Parameters.AddWithValue("@Soyad", txtboxSoyad.Text);
                musteriCmd.Parameters.AddWithValue("@Email", txtboxEmail.Text);
                musteriCmd.Parameters.AddWithValue("@Telefon", txtboxTelefon.Text);
                musteriCmd.Parameters.AddWithValue("@Sehir", txtboxSehir.Text);
                musteriCmd.Parameters.AddWithValue("@Adres", txtboxAdres.Text);
                musteriCmd.ExecuteNonQuery();

                string biletQuery = @"
                    INSERT INTO Biletler (SeferID, KoltukNo, MusteriTC, BinisDurakSira, InisDurakSira)
                    VALUES (@SeferID, @KoltukNo, @MusteriTC, @BinisDurakSira, @InisDurakSira)";
                SqlCommand biletCmd = new SqlCommand(biletQuery, conn);
                biletCmd.Parameters.AddWithValue("@SeferID", _seferID);
                biletCmd.Parameters.AddWithValue("@KoltukNo", _koltukNo);
                biletCmd.Parameters.AddWithValue("@MusteriTC", tc);
                biletCmd.Parameters.AddWithValue("@BinisDurakSira", _binisDurakSira);
                biletCmd.Parameters.AddWithValue("@InisDurakSira", _inisDurakSira);
                biletCmd.ExecuteNonQuery();

                MessageBox.Show("Bilet başarıyla oluşturuldu.");
                this.Close();
            }
        }

        private void txtboxTC_TextChanged(object sender, EventArgs e)
        {
            txtboxTC.Properties.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtboxTC.Text, "[^0-9]"))
            {
                txtboxTC.Text = System.Text.RegularExpressions.Regex.Replace(txtboxTC.Text, "[^0-9]", "");
                if (txtboxTC.MaskBox != null)
                    txtboxTC.MaskBox.MaskBoxSelectionStart = txtboxTC.Text.Length;
            }
        }

        private void txtboxTelefon_TextChanged(object sender, EventArgs e)
        {
            txtboxTelefon.Properties.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtboxTelefon.Text, "[^0-9]"))
            {
                txtboxTelefon.Text = System.Text.RegularExpressions.Regex.Replace(txtboxTelefon.Text, "[^0-9]", "");
                if (txtboxTelefon.MaskBox != null)
                    txtboxTelefon.MaskBox.MaskBoxSelectionStart = txtboxTelefon.Text.Length;
            }
        }
    }
}