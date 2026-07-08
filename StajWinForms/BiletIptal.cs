using DevExpress.XtraEditors;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class BiletIptal : XtraForm
    {
        public BiletIptal()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string tc = txtboxTC.Text.Trim();
            if (tc.Length == 0) return;

            string query = @"
                SELECT b.BiletID, b.SeferID, b.KoltukNo,
                       b.BinisDurakSira, b.InisDurakSira
                FROM Biletler b
                WHERE b.MusteriTC = @TC";

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(DbConfig.ConnectionString))
            {
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TC", tc);
                new SqlDataAdapter(cmd).Fill(dt);
            }

            gridBiletler.DataSource = dt;
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0)
            {
                MessageBox.Show("Lütfen iptal edilecek bileti seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int biletID = Convert.ToInt32(gridView.GetFocusedRowCellValue("BiletID"));

            var onay = MessageBox.Show("Bu bileti iptal etmek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            using (var conn = new SqlConnection(DbConfig.ConnectionString))
            {
                var cmd = new SqlCommand("DELETE FROM Biletler WHERE BiletID = @BiletID", conn);
                cmd.Parameters.AddWithValue("@BiletID", biletID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Bilet başarıyla iptal edildi.");
            btnSorgula_Click(sender, e);
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
