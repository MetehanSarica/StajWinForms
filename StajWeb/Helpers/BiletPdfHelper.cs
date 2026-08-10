using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using StajWeb.Dtos;

namespace StajWeb.Helpers
{
    public static class BiletPdfHelper
    {
        public static byte[] Olustur(
            string adSoyad, string tc, string telefon, string email,
            string sehir, string cinsiyet, string adres,
            int koltukNo, int seferNo,
            string kalkisSehir, string varisSehir, DateTime kalkisZamani)
        {
            return Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(827, 340, Unit.Point);
                    page.Margin(25, Unit.Point);
                    page.PageColor(Colors.White);

                    page.Header().Background(Colors.Blue.Darken2).Padding(10).Row(row =>
                    {
                        row.RelativeItem().Text("Otobüs Bileti")
                            .FontSize(20).Bold().FontColor(Colors.White).AlignCenter();
                    });

                    page.Content().PaddingTop(8).Column(col =>
                    {
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Text($"Güzergah: {kalkisSehir} → {varisSehir} | {kalkisZamani:dd.MM.yyyy HH:mm}")
                                .FontSize(9).FontColor(Colors.Grey.Darken2);
                            row.ConstantItem(130).Text($"Koltuk No: {koltukNo}")
                                .FontSize(12).Bold().FontColor(Colors.Red.Darken1).AlignRight();
                        });

                        col.Item().PaddingTop(6).Table(table =>
                        {
                            table.ColumnsDefinition(c =>
                            {
                                c.ConstantColumn(110);
                                c.RelativeColumn();
                                c.ConstantColumn(110);
                                c.RelativeColumn();
                            });

                            void Satir(string etiket, string deger)
                            {
                                table.Cell().Text(etiket).SemiBold().FontSize(9).FontColor(Colors.Grey.Darken2);
                                table.Cell().Text(deger).FontSize(9);
                            }

                            Satir("Ad Soyad", adSoyad);
                            Satir("TC Kimlik No", tc);
                            Satir("Telefon", telefon);
                            Satir("E-posta", email);
                            Satir("Şehir", sehir);
                            Satir("Cinsiyet", cinsiyet == "E" ? "Erkek" : cinsiyet == "K" ? "Kadın" : cinsiyet);
                            table.Cell().Text("Adres").SemiBold().FontSize(9).FontColor(Colors.Grey.Darken2);
                            table.Cell().ColumnSpan(3).Text(adres).FontSize(9);
                        });
                    });

                    page.Footer().AlignCenter().PaddingTop(4)
                        .Text($"Sefer No: {seferNo} | Bilet Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}")
                        .FontSize(8).FontColor(Colors.Grey.Darken1);
                });

            }).GeneratePdf();
        }

        public static byte[] OlusturCoklu(List<BiletDetayDto> detaylar)
        {
            return Document.Create(doc =>
            {
                foreach (var d in detaylar)
                {
                    doc.Page(page =>
                    {
                        page.Size(827, 340, Unit.Point);
                        page.Margin(25, Unit.Point);
                        page.PageColor(Colors.White);

                        page.Header().Background(Colors.Blue.Darken2).Padding(10).Row(row =>
                        {
                            row.RelativeItem().Text("Otobüs Bileti")
                                .FontSize(20).Bold().FontColor(Colors.White).AlignCenter();
                        });

                        page.Content().PaddingTop(8).Column(col =>
                        {
                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text($"Güzergah: {d.KalkisSehirAdi} → {d.VarisSehirAdi} | {d.KalkisZamani:dd.MM.yyyy HH:mm}")
                                    .FontSize(9).FontColor(Colors.Grey.Darken2);
                                row.ConstantItem(130).Text($"Koltuk No: {d.KoltukNo}")
                                    .FontSize(12).Bold().FontColor(Colors.Red.Darken1).AlignRight();
                            });

                            col.Item().PaddingTop(6).Table(table =>
                            {
                                table.ColumnsDefinition(c =>
                                {
                                    c.ConstantColumn(110);
                                    c.RelativeColumn();
                                    c.ConstantColumn(110);
                                    c.RelativeColumn();
                                });

                                void Satir(string etiket, string deger)
                                {
                                    table.Cell().Text(etiket).SemiBold().FontSize(9).FontColor(Colors.Grey.Darken2);
                                    table.Cell().Text(deger).FontSize(9);
                                }

                                Satir("Ad Soyad", $"{d.MusteriAd} {d.MusteriSoyad}");
                                Satir("TC Kimlik No", d.MusteriTc);
                                Satir("Telefon", d.MusteriTelefon);
                                Satir("E-posta", d.MusteriEmail);
                                Satir("Şehir", d.MusteriSehir);
                                Satir("Cinsiyet", d.Cinsiyet == "E" ? "Erkek" : d.Cinsiyet == "K" ? "Kadın" : d.Cinsiyet);
                                table.Cell().Text("Adres").SemiBold().FontSize(9).FontColor(Colors.Grey.Darken2);
                                table.Cell().ColumnSpan(3).Text(d.MusteriAdres).FontSize(9);
                            });
                        });

                        page.Footer().AlignCenter().PaddingTop(4)
                            .Text($"Sefer No: {d.SeferId}  |  Bilet Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}")
                            .FontSize(8).FontColor(Colors.Grey.Darken1);
                    });
                }
            }).GeneratePdf();
        }
    }
}
