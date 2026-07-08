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
        public MusteriKaydi()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tc = txtboxTC.Text.Trim();
            if (tc.Length != 11 || tc[0] == '0')
            {
                MessageBox.Show("TC Kimlik No 11 haneli olmalı ve 0 ile başlamamalıdır.", "Geçersiz TC",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string telefon = txtboxTelefon.Text.Trim();
            if (telefon.Length > 0 && telefon[0] == '0')
            {
                MessageBox.Show("Telefon numarası 0 ile başlamamalıdır.", "Geçersiz Telefon",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxTelefon.Text = "";
            }

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
