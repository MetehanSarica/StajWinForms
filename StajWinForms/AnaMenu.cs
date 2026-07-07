using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace StajWinForms
{
    public partial class AnaMenu : DevExpress.XtraEditors.XtraForm
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
        }

        /*
        private void LoadData()
        {}
        */

        private void btnAra_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@sehir", "%" + txtboxAra.Text + "%");
                SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridVeriler.DataSource = tablo;
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("Lütfen önce bir sefer seçin.");
                return;
            }
            int seferID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SeferID"));
            SecimEkrani secimEkrani = new SecimEkrani(seferID);
            secimEkrani.ShowDialog();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            BiletSorgula biletSorgula = new BiletSorgula();
            biletSorgula.ShowDialog();
        }

        private void btnSeferDetaylar_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seferID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SeferID"));
                SeferDetay seferDetay = new SeferDetay(seferID);
                seferDetay.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir sefer seçin.");
            }
        }
    }
}
