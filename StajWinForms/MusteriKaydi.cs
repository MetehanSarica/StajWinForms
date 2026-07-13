using DevExpress.XtraEditors;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace StajWinForms
{
    public partial class MusteriKaydi : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
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
            spTC.EditValue = null;
            lblKoltukBilgi.Text = $"Seçilen Koltuk: {_koltukNo}";
            _ = SehirleriYukle();
        }

        private async Task SehirleriYukle()
        {
            try
            {
                var sehirler = await _http.GetFromJsonAsync<List<SehirlerModel>>("api/sehirler", _jsonOpts) ?? new();
                cmbSehir.Properties.Items.AddRange(sehirler.Select(s => s.SehirAdi).ToArray());
            }
            catch
            {
                MessageBox.Show("Şehirler yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Dogrula()
        {
            string telefon = TelefonRakamlari();
            if (spTC.Text.Trim().Length == 0 ||
                txtboxAd.Text.Trim().Length == 0 ||
                txtboxSoyad.Text.Trim().Length == 0 ||
                txtboxEmail.Text.Trim().Length == 0 ||
                telefon.Length == 0 ||
                cmbSehir.SelectedIndex == -1 ||
                memoAdres.Text.Trim().Length == 0 ||
                cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string tc = spTC.Text.Trim();
            if (tc.Length != 11 || tc[0] == '0')
            {
                MessageBox.Show("TC Kimlik No 11 haneli olmalı ve 0 ile başlamamalıdır.", "Geçersiz TC",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (telefon.Length != 11 || telefon[0] != '0')
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalı ve 0 ile başlamalıdır.", "Geçersiz Telefon",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string TelefonRakamlari() =>
            System.Text.RegularExpressions.Regex.Replace(txtboxTelefon.Text, "[^0-9]", "");

        private async void btnBiletOlustur_Click(object sender, EventArgs e)
        {
            if (!Dogrula()) return;

            var model = new SatinAlModel
            {
                MusteriTc = spTC.Text.Trim(),
                MusteriAd = txtboxAd.Text.Trim(),
                MusteriSoyad = txtboxSoyad.Text.Trim(),
                MusteriMail = txtboxEmail.Text.Trim(),
                MusteriTelefon = TelefonRakamlari(),
                MusteriSehir = cmbSehir.Text.Trim(),
                MusteriAdres = memoAdres.Text.Trim(),
                MusteriCinsiyet = cmbCinsiyet.SelectedItem.ToString()!.Substring(0, 1).ToUpper(),
                SeferId = _seferID,
                KoltukNo = _koltukNo,
                BinisDurakSira = _binisDurakSira,
                InisDurakSira = _inisDurakSira
            };

            try
            {
                var response = await _http.PostAsJsonAsync("api/biletler/satinal", model);

                if (response.IsSuccessStatusCode)
                {
                    BiletPdfOlustur();
                    MessageBox.Show("Bilet başarıyla oluşturuldu.");
                    this.Close();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    var mesaj = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(mesaj, "Koltuk Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bilet oluşturulamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Sunucuya ulaşılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spTC_EditValueChanged(object sender, EventArgs e)
        {
            spTC.Properties.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(spTC.Text, "[^0-9]"))
            {
                spTC.Text = System.Text.RegularExpressions.Regex.Replace(spTC.Text, "[^0-9]", "");
                if (spTC.MaskBox != null)
                    spTC.MaskBox.MaskBoxSelectionStart = spTC.Text.Length;
            }
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void BiletPdfOlustur()
        {
            string dosyaYolu = Path.GetTempPath() + $"Bilet_{spTC.Text}_{_koltukNo}_{txtboxAd.Text}.pdf";
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
                                table.Cell().Text(spTC.Text);

                                table.Cell().Text("Telefon:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(txtboxTelefon.Text);
                                table.Cell().Text("Email:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(txtboxEmail.Text);

                                table.Cell().Text("Şehir:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(cmbSehir.Text);
                                table.Cell().Text("Cinsiyet:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(cmbCinsiyet.SelectedItem.ToString());

                                table.Cell().Text("Adres:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().ColumnSpan(3).Text(memoAdres.Text);
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
    internal class SatinAlModel
    {
        public string MusteriTc { get; set; } = "";
        public string MusteriAd { get; set; } = ""; public string MusteriSoyad { get; set; } = "";
        public string MusteriMail { get; set; } = ""; public string MusteriTelefon { get; set; } = "";
        public string MusteriSehir { get; set; } = "";
        public string MusteriAdres { get; set; } = "";
        public string MusteriCinsiyet { get; set; } = "";
        public int SeferId { get; set; }
        public int KoltukNo { get; set; }
        public int BinisDurakSira { get; set; }
        public int InisDurakSira { get; set; }
    }
}