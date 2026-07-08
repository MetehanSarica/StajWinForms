using DevExpress.XtraEditors;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class BiletSorgula : XtraForm
    {
        public BiletSorgula()
        {
            InitializeComponent();
        }

        private void btnBiletSorgu_Click(object sender, EventArgs e)
        {
            if (txtboxTC.Text.Length < 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxTC.EditValue = null;
                return;
            }

            string query = @"
                SELECT b.BiletID, b.KoltukNo, f.FirmaAdi,
                       k.SehirAdi AS KalkisSehir, v.SehirAdi AS VarisSehir,
                       s.KalkisZamani, s.Fiyat
                FROM Biletler b
                JOIN Seferler s ON b.SeferID = s.SeferID
                JOIN Firmalar f ON s.FirmaID = f.FirmaID
                JOIN Sehirler k ON s.KalkisSehirID = k.SehirID
                JOIN Sehirler v ON s.VarisSehirID = v.SehirID
                WHERE b.MusteriTC = @TC";

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TC", txtboxTC.Text.Trim());
                SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridSorgu.DataSource = tablo;
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
    }
}
