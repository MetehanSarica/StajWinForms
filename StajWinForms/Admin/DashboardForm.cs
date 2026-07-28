using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;

namespace StajWinForms.Admin
{
    public partial class DashboardForm : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        public DashboardForm()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadData();
        }

        private async Task LoadData()
        {
            var data = await _http.GetFromJsonAsync<DashboardDto>("api/istatistikler", _opts) ?? new();

            
            var group = new DevExpress.XtraEditors.TileGroup();
            tileControl.Groups.Add(group);

            group.Items.Add(CreateTile("Toplam Bilet", data.ToplamBilet.ToString(), Color.FromArgb(0, 120, 215)));
            group.Items.Add(CreateTile("Toplam Gelir", $"₺{data.ToplamGelir:N0}", Color.FromArgb(16, 124, 16)));
            group.Items.Add(CreateTile("Toplam Sefer", data.AktifSeferler.ToString(), Color.FromArgb(202, 80, 16)));


            var series = new Series("Güzergah", ViewType.Bar);
            foreach (var g in data.PopulerGuzergahlar)
                series.Points.Add(new SeriesPoint(g.Guzergah, g.BiletSayisi));

            chartControl.Series.Add(series);
            ((XYDiagram)chartControl.Diagram).AxisX.Label.Angle = -15;
        }

        private DevExpress.XtraEditors.TileItem CreateTile(string baslik, string deger, Color renk)
        {
            var tile = new DevExpress.XtraEditors.TileItem();
            tile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            tile.AppearanceItem.Normal.BackColor = renk;
            tile.AppearanceItem.Normal.Options.UseBackColor = true;

            var lblBaslik = new DevExpress.XtraEditors.TileItemElement { Text = baslik, TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft };
            var lblDeger = new DevExpress.XtraEditors.TileItemElement { Text = deger, TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft };
            lblDeger.Appearance.Normal.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblDeger.Appearance.Normal.Options.UseFont = true;

            tile.Elements.Add(lblBaslik);
            tile.Elements.Add(lblDeger);
            return tile;
        }
    }

    class DashboardDto
    {
        public int ToplamBilet { get; set; }
        public decimal ToplamGelir { get; set; }
        public int AktifSeferler { get; set; }
        public List<DashboardGuzergahDto> PopulerGuzergahlar { get; set; } = new();
    }

    class DashboardGuzergahDto
    {
        public string Guzergah { get; set; } = "";
        public int BiletSayisi { get; set; }
    }
}
