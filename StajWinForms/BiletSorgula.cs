using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StajWinForms
{
    public partial class BiletSorgula : Form
    {
        public BiletSorgula()
        {
            InitializeComponent();
        }

        private void btnBiletSorgu_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT s.SeferID, f.FirmaAdi,
                       k.SehirAdi AS KalkisSehir, v.SehirAdi AS VarisSehir,
                       s.KalkisZamani, s.Fiyat, s.BosKoltuk
                FROM Seferler s
                JOIN Firmalar f ON s.FirmaID = f.FirmaID
                JOIN Sehirler k ON s.KalkisSehirID = k.SehirID
                JOIN Sehirler v ON s.VarisSehirID = v.SehirID
                WHERE k.SehirAdi LIKE @sehir OR v.SehirAdi LIKE @sehir";

            using (SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=dbStaj;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sehir", "%" + txtboxTC.Text + "%");
                SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridSorgu.AutoGenerateColumns = true;
                dataGridSorgu.DataSource = tablo;
            }
        }

        private void txtboxTC_TextChanged(object sender, EventArgs e)
        {
            txtboxTC.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtboxTC.Text, "[^0-9]"))
            {
                txtboxTC.Text = System.Text.RegularExpressions.Regex.Replace(txtboxTC.Text, "[^0-9]", "");

                txtboxTC.SelectionStart = txtboxTC.Text.Length;
            }
        }
    }
}
