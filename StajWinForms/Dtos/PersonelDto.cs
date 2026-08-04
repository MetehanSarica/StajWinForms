using System;
using System.Collections.Generic;
using System.Text;

namespace StajWinForms.Dtos
{
    public class PersonelDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = "";
        public string Soyad { get; set; } = "";
        public string? Email { get; set; }
        public string? Unvan { get; set; }
        public decimal? Maas { get; set; }
        public DateOnly? IseGirisTarihi { get; set; }
    }
}
