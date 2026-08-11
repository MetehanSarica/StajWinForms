using System;
using System.Collections.Generic;
using System.Text;

namespace StajWinForms.Dtos
{
    public class KullaniciYetkiDto
    {
        public string FormAdi { get; set; } = "";
        public bool Ekle {  get; set; }
        public bool Sil {  get; set; }
        public bool Degistir { get; set; }
        public bool Incele {  get; set; }
        public bool Ata {  get; set; }
        public bool Kaldir { get; set; }
        public bool Kaydet {  get; set; }
        public bool AktifPasif { get; set; }
    }
}
