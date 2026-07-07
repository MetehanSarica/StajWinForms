using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class SecimEkrani : Form
    {
        private const string ConnStr = "Server=(localdb)\\MSSQLLocalDB;Database=dbStaj;Trusted_Connection=True;";

        private readonly int _seferID;
        private int? _secilenKoltukNo;

        // Segment seçim kontrolleri (designer'a dokunmadan kod ile ekliyoruz)
        private readonly Label lblBinis    = new Label();
        private readonly Label lblInis     = new Label();
        private readonly ComboBox cmbBinis = new ComboBox();
        private readonly ComboBox cmbInis  = new ComboBox();
        // btnFiltrele field'ı Designer.cs'de partial class tarafından tanımlanıyor

        public SecimEkrani(int seferID)
        {
            _seferID = seferID;
            InitializeComponent();
        }
        private void SecimEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                KoltuklariNumaralandir();
                EkKontrollerEkle();
                DuraklariYukle();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KoltuklariNumaralandir()
        {
            var siraliButonlar = this.Controls.OfType<Button>()
                .Where(btn => btn.Name != "btnKoltukSec" && btn.Name != "btnFiltrele")
                .OrderBy(btn => btn.Location.X)
                .ThenBy(btn => btn.Location.Y)
                .ToList();

            int koltukNo = 1;
            foreach (var btn in siraliButonlar)
            {
                btn.Text = koltukNo.ToString();
                btn.Name = "koltuk" + koltukNo;
                btn.Click += KoltukButonu_Click;
                koltukNo++;
            }
        }
        private void EkKontrollerEkle()
        {
            this.ClientSize = new Size(800, 490);

            lblBinis.Text = "Biniş Durağı:";
            lblBinis.Location = new Point(12, 440);
            lblBinis.AutoSize = true;

            cmbBinis.Location = new Point(110, 437);
            cmbBinis.Width = 170;
            cmbBinis.DropDownStyle = ComboBoxStyle.DropDownList;

            lblInis.Text = "İniş Durağı:";
            lblInis.Location = new Point(295, 440);
            lblInis.AutoSize = true;

            cmbInis.Location = new Point(380, 437);
            cmbInis.Width = 170;
            cmbInis.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Controls.AddRange(new Control[] { lblBinis, cmbBinis, lblInis, cmbInis });
        }
        private void DuraklariYukle()
        {
            string query = @"
                SELECT sd.DurakSira, s.SehirAdi
                FROM SeferDuraklar sd
                JOIN Sehirler s ON sd.SehirID = s.SehirID
                WHERE sd.SeferID = @SeferID
                ORDER BY sd.DurakSira";

            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(ConnStr))
            {
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SeferID", _seferID);
                new SqlDataAdapter(cmd).Fill(dt);
            }

            cmbBinis.DataSource = dt.Copy();
            cmbBinis.DisplayMember = "SehirAdi";
            cmbBinis.ValueMember = "DurakSira";

            cmbInis.DataSource = dt.Copy();
            cmbInis.DisplayMember = "SehirAdi";
            cmbInis.ValueMember = "DurakSira";

            if (cmbInis.Items.Count > 0)
                cmbInis.SelectedIndex = cmbInis.Items.Count - 1;
        }
        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            if (cmbBinis.SelectedValue == null || cmbInis.SelectedValue == null) return;

            int binisSira = (int)cmbBinis.SelectedValue;
            int inisSira  = (int)cmbInis.SelectedValue;

            if (binisSira >= inisSira)
            {
                MessageBox.Show("Biniş durağı iniş durağından önce olmalıdır.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doluKoltuklar = DoluKoltuklariGetir(binisSira, inisSira);
            _secilenKoltukNo = null;

            foreach (var btn in KoltukButonlari())
            {
                int no = int.Parse(btn.Text);
                bool dolu = doluKoltuklar.Contains(no);
                btn.BackColor = dolu ? Color.IndianRed : Color.LightGreen;
                btn.Enabled   = !dolu;
            }
        }
        private HashSet<int> DoluKoltuklariGetir(int binisSira, int inisSira)
        {
            string query = @"
                SELECT KoltukNo
                FROM Biletler
                WHERE SeferID        = @SeferID
                  AND BinisDurakSira < @InisSira
                  AND InisDurakSira  > @BinisSira";

            var dolu = new HashSet<int>();
            using (var conn = new SqlConnection(ConnStr))
            {
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SeferID",  _seferID);
                cmd.Parameters.AddWithValue("@BinisSira", binisSira);
                cmd.Parameters.AddWithValue("@InisSira",  inisSira);
                conn.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    dolu.Add((int)reader["KoltukNo"]);
            }
            return dolu;
        }
        private void KoltukButonu_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            foreach (var b in KoltukButonlari())
                if (b.BackColor == Color.Yellow)
                    b.BackColor = Color.LightGreen;

            _secilenKoltukNo = int.Parse(btn.Text);
            btn.BackColor = Color.Yellow;
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            if (_secilenKoltukNo == null)
            {
                MessageBox.Show("Lütfen önce bir koltuk seçin.");
                return;
            }

            MusteriKaydi musteriKaydi = new MusteriKaydi();
            musteriKaydi.Show();
        }

        private IEnumerable<Button> KoltukButonlari() =>
            this.Controls.OfType<Button>().Where(b => b.Name.StartsWith("koltuk"));
    }
}
