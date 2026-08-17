using System;
using System.Collections.Generic;
using System.Text;

namespace StajWinForms.Tests
{
    public class YetkiMatrisiTests
    {
        private static readonly Dictionary<string, HashSet<string>> FormYetkileri = new()
        {
            ["dashboard"] = new() { "Incele" },
            ["sefer_yonetimi"] = new() { "Ekle", "Degistir", "Sil", "Incele", "AktifPasif" },
            ["bilet_arama"] = new() { "Incele" },
            ["firma_yonetimi"] = new() { "Ekle", "Degistir", "Sil", "Incele" },
            ["otobus_yonetimi"] = new() { "Ekle", "Degistir", "Sil", "Incele" },
            ["musteri_yonetimi"] = new() { "Ekle", "Degistir", "Sil", "Incele" },
            ["otogar_yonetimi"] = new() { "Ekle", "Degistir", "Sil" },
            ["personel_yonetimi"] = new() { "Ekle", "Degistir", "Sil" },
            ["firma_otobus_esleme"] = new() { "Ata", "Kaldir" },
            ["kaptan_esleme"] = new() { "Ata", "Kaldir" },
            ["sefer_otobus_esleme"] = new() { "Ata", "Kaldir" },
            ["kullanici_yonetimi"] = new() { "Ekle", "Degistir", "Sil", "Incele" },
            ["yetki_atama"] = new() { "Kaydet" },
        };

        [Fact]
        public void SeferYonetimi_AktifPasifIcermeli()
            => Assert.Contains("AktifPasif", FormYetkileri["sefer_yonetimi"]);

        [Fact]
        public void FirmaOtobusEsleme_EkleIcermemeli()
            => Assert.DoesNotContain("Ekle", FormYetkileri["firma_otobus_esleme"]);

        [Fact]
        public void YetkiAtama_SadeceKaydetIcermeli()
            => Assert.Equal(new HashSet<string> { "Kaydet" }, FormYetkileri["yetki_atama"]);

        [Fact]
        public void TumFormlar_EnAzBirYetkiIcermeli()
            => Assert.All(FormYetkileri.Values, set => Assert.NotEmpty(set));
    }
}
