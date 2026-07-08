using DevExpress.XtraEditors;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class SecimEkrani : XtraForm
    {
        private static string ConnStr => DbConfig.ConnectionString;

        private readonly int _seferID;
        private int? _secilenKoltukNo;

        private readonly LabelControl lblBinis  = new LabelControl();
        private readonly LabelControl lblInis   = new LabelControl();
        private readonly LookUpEdit   cmbBinis  = new LookUpEdit();
        private readonly LookUpEdit   cmbInis   = new LookUpEdit();

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
            var siraliButonlar = this.Controls.OfType<SimpleButton>()
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

            cmbBinis.Location = new Point(110, 437);
            cmbBinis.Width = 170;
            cmbBinis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            lblInis.Text = "İniş Durağı:";
            lblInis.Location = new Point(295, 440);

            cmbInis.Location = new Point(380, 437);
            cmbInis.Width = 170;
            cmbInis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

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

            var dtBinis = dt.Copy();
            cmbBinis.Properties.DataSource = dtBinis;
            cmbBinis.Properties.DisplayMember = "SehirAdi";
            cmbBinis.Properties.ValueMember = "DurakSira";

            var dtInis = dt.Copy();
            cmbInis.Properties.DataSource = dtInis;
            cmbInis.Properties.DisplayMember = "SehirAdi";
            cmbInis.Properties.ValueMember = "DurakSira";

            if (dtInis.Rows.Count > 0)
                cmbInis.EditValue = dtInis.Rows[dtInis.Rows.Count - 1]["DurakSira"];
        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            if (cmbBinis.EditValue == null || cmbInis.EditValue == null) return;

            int binisSira = Convert.ToInt32(cmbBinis.EditValue);
            int inisSira  = Convert.ToInt32(cmbInis.EditValue);

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
                btn.Appearance.BackColor = dolu ? Color.IndianRed : Color.LightGreen;
                btn.Appearance.Options.UseBackColor = true;
                btn.Enabled = !dolu;
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
                cmd.Parameters.AddWithValue("@SeferID",   _seferID);
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
            if (sender is not SimpleButton btn) return;

            foreach (var b in KoltukButonlari())
                if (b.Appearance.BackColor == Color.Yellow)
                    b.Appearance.BackColor = Color.LightGreen;

            _secilenKoltukNo = int.Parse(btn.Text);
            btn.Appearance.BackColor = Color.Yellow;
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

        private IEnumerable<SimpleButton> KoltukButonlari() =>
            this.Controls.OfType<SimpleButton>().Where(b => b.Name.StartsWith("koltuk"));
    }
}
