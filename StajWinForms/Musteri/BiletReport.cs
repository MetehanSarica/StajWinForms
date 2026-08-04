using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.Drawing.Internal;

namespace StajWinForms.Musteri
{
    public class BiletReport : XtraReport
    {
        public BiletReport(string adSoyad, string tc, string telefon, string email,
            string sehir, string cinsiyet, string adres, int koltukNo, int seferNo)
        {
            this.Bands.Add(new ReportHeaderBand { HeightF = 50 });
            this.Bands.Add(new DetailBand { HeightF = 195 });
            this.Bands.Add(new ReportFooterBand { HeightF = 25 });

            var header = (ReportHeaderBand)this.Bands[BandKind.ReportHeader];
            var detail = (DetailBand)this.Bands[BandKind.Detail];
            var footer = (ReportFooterBand)this.Bands[BandKind.ReportFooter];

            var lblBaslik = new XRLabel
            {
                Text = "Otobüs Bileti",
                Font = new System.Drawing.Font("Tahoma", 18, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.FromArgb(21, 101, 192),
                BoundsF = new System.Drawing.RectangleF(0, 0, 777, 45),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            };
            header.Controls.Add(lblBaslik);

            var lblKoltuk = new XRLabel
            {
                Text = $"Koltuk No: {koltukNo}",
                Font = new System.Drawing.Font("Tahoma", 14, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Red,
                BoundsF = new System.Drawing.RectangleF(0, 0, 777, 30),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            };
            detail.Controls.Add(lblKoltuk);

            var alanlar = new[]
            {
                ("Ad Soyad", adSoyad),
                ("TC Kimlik No", tc),
                ("Telefon", telefon),
                ("E-posta", email),
                ("Şehir", sehir),
                ("Cinsiyet", cinsiyet),
                ("Adres", adres)
            };

            float y = 35;
            foreach (var (etiket, deger) in alanlar)
            {
                var lbl = new XRLabel
                {
                    Text = etiket,
                    Font = new System.Drawing.Font("Tahoma", 9, System.Drawing.FontStyle.Bold),
                    BoundsF = new System.Drawing.RectangleF(0, y, 120, 20),
                };
                var val = new XRLabel
                {
                    Text = deger,
                    Font = new System.Drawing.Font("Tahoma", 9),
                    BoundsF = new System.Drawing.RectangleF(125, y, 652, 20)
                };
                detail.Controls.Add(lbl);
                detail.Controls.Add(val);
                y += 22;
            }

            var lblFooter = new XRLabel
            {
                Text = $"Sefer No: {seferNo} | Bilet Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}",
                Font = new System.Drawing.Font("Tahoma", 8),
                ForeColor = System.Drawing.Color.Gray,
                BoundsF = new System.Drawing.RectangleF(0, 0, 777, 25),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            };
            footer.Controls.Add(lblFooter);

            this.PageWidth = 827;
            this.PageHeight = 305;
            this.Landscape = false;
            this.Margins = new System.Drawing.Printing.Margins(25, 25, 15, 15);
        }
    }
}