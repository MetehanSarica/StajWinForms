using DevExpress.LookAndFeel;
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
        private List<int> _secilenKoltuklar = new List<int>();
        private object? _oncekiBinisDuragi;
        private object? _oncekiInisDuragi;

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
                DuraklariYukle();
                KoltuklariRenklendir();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KoltuklariNumaralandir()
        {
            var siraliButonlar = this.Controls.OfType<SimpleButton>()
                .Where(btn => btn.Name != "btnKoltukSec")
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

        private void cmbBinis_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbBinis.EditValue != null && cmbInis.EditValue != null)
            {
                int binisSira = Convert.ToInt32(cmbBinis.EditValue);
                int inisSira  = Convert.ToInt32(cmbInis.EditValue);
                if (binisSira >= inisSira)
                {
                    MessageBox.Show("Biniş durağı iniş durağından önce olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbBinis.EditValue = _oncekiBinisDuragi;
                    return;
                }
            }

            _oncekiBinisDuragi = cmbBinis.EditValue;
            KoltuklariRenklendir();
        }

        private void cmbInis_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbBinis.EditValue != null && cmbInis.EditValue != null)
            {
                int binisSira = Convert.ToInt32(cmbBinis.EditValue);
                int inisSira  = Convert.ToInt32(cmbInis.EditValue);
                if (binisSira >= inisSira)
                {
                    MessageBox.Show("İniş durağı biniş durağından sonra olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbInis.EditValue = _oncekiInisDuragi;
                    return;
                }
            }

            _oncekiInisDuragi = cmbInis.EditValue;
            KoltuklariRenklendir();
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

            if (dtBinis.Rows.Count > 0)
            {
                cmbBinis.EditValue = dtBinis.Rows[0]["DurakSira"];
                _oncekiBinisDuragi = cmbBinis.EditValue;
            }

            if (dtInis.Rows.Count > 0)
            {
                cmbInis.EditValue = dtInis.Rows[dtInis.Rows.Count - 1]["DurakSira"];
                _oncekiInisDuragi = cmbInis.EditValue;
            }
        }

        private void KoltuklariRenklendir()
        {
            HashSet<int> doluKoltuklar;

            if (cmbBinis.EditValue != null && cmbInis.EditValue != null)
            {
                int binisSira = Convert.ToInt32(cmbBinis.EditValue);
                int inisSira  = Convert.ToInt32(cmbInis.EditValue);
                if (binisSira >= inisSira) return;
                doluKoltuklar = DoluKoltuklariGetir(binisSira, inisSira);
            }
            else
            {
                doluKoltuklar = TumDoluKoltuklariGetir();
            }

            _secilenKoltuklar.Clear();

            foreach (var btn in KoltukButonlari())
            {
                int no    = int.Parse(btn.Text);
                bool dolu = doluKoltuklar.Contains(no);
                KoltukRenkAyarla(btn, dolu ? Color.IndianRed : Color.LightGreen, dolu);
            }
        }

        private HashSet<int> TumDoluKoltuklariGetir()
        {
            var dolu = new HashSet<int>();
            using var conn = new SqlConnection(ConnStr);
            var cmd = new SqlCommand("SELECT KoltukNo FROM Biletler WHERE SeferID = @SeferID", conn);
            cmd.Parameters.AddWithValue("@SeferID", _seferID);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                dolu.Add((int)reader["KoltukNo"]);
            return dolu;
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
            if (sender is not SimpleButton btn) 
                return;

            int no = int.Parse(btn.Text);
            if (_secilenKoltuklar.Contains(no))
            {
                _secilenKoltuklar.Remove(no);
                KoltukRenkAyarla(btn, Color.LightGreen, false);
            }
            else
            {
                _secilenKoltuklar.Add(no);
                KoltukRenkAyarla(btn, Color.Yellow, false);
            }
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            if (_secilenKoltuklar == null || !_secilenKoltuklar.Any())
            {
                MessageBox.Show("Lütfen önce bir koltuk seçin.");
                return;
            }
            
            foreach (var no in _secilenKoltuklar)
            {
                int binisSira = cmbBinis.EditValue != null ? Convert.ToInt32(cmbBinis.EditValue) : 0;
                int inisSira = cmbInis.EditValue != null ? Convert.ToInt32(cmbInis.EditValue) : 0;
                MusteriKaydi musteriKaydi = new MusteriKaydi(_seferID, no, binisSira, inisSira);
                musteriKaydi.ShowDialog();
            }

            KoltuklariRenklendir();
        }

        private static void KoltukRenkAyarla(SimpleButton btn, Color renk, bool disabled)
        {
            btn.LookAndFeel.UseDefaultLookAndFeel = false;
            btn.LookAndFeel.Style = LookAndFeelStyle.Flat;
            btn.Appearance.BackColor  = renk;
            btn.Appearance.BackColor2 = renk;
            btn.Appearance.Options.UseBackColor = true;
            btn.AppearanceDisabled.BackColor  = renk;
            btn.AppearanceDisabled.BackColor2 = renk;
            btn.AppearanceDisabled.Options.UseBackColor = true;
            btn.Enabled = !disabled;
        }

        private IEnumerable<SimpleButton> KoltukButonlari() =>
            this.Controls.OfType<SimpleButton>().Where(b => b.Name.StartsWith("koltuk"));
    }
}
