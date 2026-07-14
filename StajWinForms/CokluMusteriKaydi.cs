using DevExpress.XtraEditors;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Size = System.Drawing.Size;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class CokluMusteriKaydi : DevExpress.XtraEditors.XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private readonly List<MusteriKaydiControl> _controls = new();

        public CokluMusteriKaydi(List<int> koltuklar, int seferId, int binisSira, int inisSira)
        {
            InitializeComponent();

            Text = "Müşteri Kayıtları";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            var panel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            int yOffset = 10;
            foreach (var koltukNo in koltuklar)
            {
                try
                {
                    var control = new MusteriKaydiControl(seferId, koltukNo, binisSira, inisSira);
                    control.Location = new Point(10, yOffset);
                    panel.Controls.Add(control); 

                    if (_controls == null) _controls = new List<MusteriKaydiControl>();
                    _controls.Add(control);

                    yOffset += control.Height + 10;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koltuk {koltukNo} için ekran oluşturulurken bir hata oluştu:\n\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                        "UserControl Hatası Yakalandı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            var btnBiletOlustur = new SimpleButton
            {
                Text = "Biletleri Oluştur",
                Size = new Size(160, 36),
                Location = new Point((450 - 160) / 2, yOffset + 5)
            };
            btnBiletOlustur.Click += BtnBiletOlustur_Click;
            panel.Controls.Add(btnBiletOlustur);

            int screenHeight = Screen.PrimaryScreen?.WorkingArea.Height ?? 800;
            int formHeight = Math.Min(yOffset + 80, screenHeight - 100);
            ClientSize = new Size(450, formHeight);
            Controls.Add(panel);
        }

        private async void BtnBiletOlustur_Click(object? sender, EventArgs e)
        {
            foreach (var ctrl in _controls)
                if (!ctrl.Dogrula()) return;

            foreach (var ctrl in _controls)
            {
                var model = ctrl.GetModel();
                try
                {
                    var response = await _http.PostAsJsonAsync("api/biletler/satinal", model);
                    if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        var mesaj = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Koltuk {model.KoltukNo}: {mesaj}", "Koltuk Dolu",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Koltuk {model.KoltukNo}: Bilet oluşturulamadı.", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Sunucuya ulaşılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (var ctrl in _controls)
                BiletPdfOlustur(ctrl.GetModel());

            MessageBox.Show("Tüm biletler başarıyla oluşturuldu.", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private static void BiletPdfOlustur(SatinAlModel model)
        {
            string telefonFormatli = model.MusteriTelefon.Length == 11
                ? $"0({model.MusteriTelefon[1..4]}) {model.MusteriTelefon[4..7]} {model.MusteriTelefon[7..9]} {model.MusteriTelefon[9..11]}"
                : model.MusteriTelefon;
            string cinsiyetAdi = model.MusteriCinsiyet == "E" ? "Erkek" : model.MusteriCinsiyet == "K" ? "Kadın" : model.MusteriCinsiyet;
            string dosyaYolu = Path.Combine(Path.GetTempPath(), $"Bilet_{model.MusteriTc}_{model.KoltukNo}_{model.MusteriAd}.pdf");
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
                                row.ConstantItem(150).Text($"Koltuk No: {model.KoltukNo}").FontSize(13).Bold().FontColor(Colors.Red.Darken1).AlignRight();
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
                                table.Cell().Text($"{model.MusteriAd} {model.MusteriSoyad}");
                                table.Cell().Text("TC No:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(model.MusteriTc);

                                table.Cell().Text("Telefon:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(telefonFormatli);
                                table.Cell().Text("Email:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(model.MusteriMail);

                                table.Cell().Text("Şehir:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(model.MusteriSehir);
                                table.Cell().Text("Cinsiyet:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(cinsiyetAdi);

                                table.Cell().Text("Adres:").SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().ColumnSpan(3).Text(model.MusteriAdres);
                            });
                        });
                    });

                    page.Footer().AlignCenter().PaddingTop(10)
                        .Text($"Sefer No: {model.SeferId}  |  Bilet Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}")
                        .FontSize(9).FontColor(Colors.Grey.Darken1);
                });
            }).GeneratePdf(dosyaYolu);
            Process.Start(new ProcessStartInfo(dosyaYolu) { UseShellExecute = true });
        }
    }
}
