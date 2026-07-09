using DevExpress.XtraEditors;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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
                txtboxAdres.Text.Trim().Length == 0 ||
                cmbCinsiyet.SelectedIndex == -1)
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
            if (telefon[0] != '0')
            {
                MessageBox.Show("Telefon numarası 0 ile başlamalıdır.", "Geçersiz Telefon",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxTelefon.Text = "";
                return false;
            }

            return true;
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
                        INSERT INTO Musteri (TC, Ad, Soyad, Email, Telefon, Sehir, Adres, Cinsiyet)
                        VALUES (@TC, @Ad, @Soyad, @Email, @Telefon, @Sehir, @Adres, @Cinsiyet)";
                SqlCommand musteriCmd = new SqlCommand(musteriQuery, conn);
                musteriCmd.Parameters.AddWithValue("@TC", tc);
                musteriCmd.Parameters.AddWithValue("@Ad", txtboxAd.Text);
                musteriCmd.Parameters.AddWithValue("@Soyad", txtboxSoyad.Text);
                musteriCmd.Parameters.AddWithValue("@Email", txtboxEmail.Text);
                musteriCmd.Parameters.AddWithValue("@Telefon", txtboxTelefon.Text);
                musteriCmd.Parameters.AddWithValue("@Sehir", txtboxSehir.Text);
                musteriCmd.Parameters.AddWithValue("@Adres", txtboxAdres.Text);
                musteriCmd.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.SelectedItem.ToString().Substring(0, 1).ToUpper());
                musteriCmd.ExecuteNonQuery();

                string biletQuery = @"
                    INSERT INTO Biletler (SeferID, KoltukNo, MusteriTC, BinisDurakSira, InisDurakSira, Cinsiyet)
                    VALUES (@SeferID, @KoltukNo, @MusteriTC, @BinisDurakSira, @InisDurakSira, @Cinsiyet)";
                SqlCommand biletCmd = new SqlCommand(biletQuery, conn);
                biletCmd.Parameters.AddWithValue("@SeferID", _seferID);
                biletCmd.Parameters.AddWithValue("@KoltukNo", _koltukNo);
                biletCmd.Parameters.AddWithValue("@MusteriTC", tc);
                biletCmd.Parameters.AddWithValue("@BinisDurakSira", _binisDurakSira);
                biletCmd.Parameters.AddWithValue("@InisDurakSira", _inisDurakSira);
                biletCmd.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.SelectedItem.ToString().Substring(0, 1).ToUpper());
                biletCmd.ExecuteNonQuery();

                BiletPdfOlustur();
                
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

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void BiletPdfOlustur()
        {
            string dosyaYolu = Path.GetTempPath() + $"Bilet_{txtboxTC.Text}_{_koltukNo}_{txtboxAd.Text}.pdf";
            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.A5.Landscape());
                    page.Margin(30);
                    page.Background().Background(Colors.Grey.Lighten3);

                    page.Header().PaddingBottom(10).Column(col =>
                    {
                        col.Item().Background(Colors.Blue.Darken2).Padding(12).Row(row =>
                        {
                            row.RelativeItem().Text("OTOBÜS BİLETİ").FontSize(22).Bold().FontColor(Colors.White).AlignCenter();
                        });
                    });

                    page.Content().PaddingTop(15).Column(col =>
                    {
                        col.Item().Background(Colors.White).Border(1).BorderColor(Colors.Grey.Lighten1).Padding(15).Column(inner =>
                        {
                            inner.Item().PaddingBottom(8).Row(row =>
                            {
                                row.RelativeItem().Text("Yolcu Bilgileri").FontSize(13).Bold().FontColor(Colors.Blue.Darken2);
                                row.ConstantItem(150).Text($"Koltuk No: {_koltukNo}").FontSize(13).Bold().FontColor(Colors.Red.Darken1).AlignRight();
                            });

                            inner.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);
                            inner.Item().PaddingTop(8).Table(table =>
                            {
                                table.ColumnsDefinition(c =>
                                {
                                    c.ConstantColumn(100);
                                    c.RelativeColumn();
                                    c.ConstantColumn(100);
                                    c.RelativeColumn();
                                });

                                table.Cell().Text("Ad Soyad:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text($"{txtboxAd.Text} {txtboxSoyad.Text}");
                                table.Cell().Text("TC No:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(txtboxTC.Text);

                                table.Cell().Text("Telefon:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(txtboxTelefon.Text);
                                table.Cell().Text("Email:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(txtboxEmail.Text);

                                table.Cell().Text("Şehir:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(txtboxSehir.Text);
                                table.Cell().Text("Cinsiyet:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(cmbCinsiyet.SelectedItem.ToString());

                                table.Cell().Text("Adres:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().ColumnSpan(3).Text(txtboxAdres.Text);
                            });
                        });
                    });

                    page.Footer().AlignCenter().PaddingTop(10)
                        .Text($"Sefer No: {_seferID}  |  Bilet Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}")
                        .FontSize(9).FontColor(Colors.Grey.Darken1);
                });
            }).GeneratePdf(dosyaYolu);
            Process.Start(new ProcessStartInfo(dosyaYolu) { UseShellExecute = true });
        }
    }
}