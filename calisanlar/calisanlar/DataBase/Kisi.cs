﻿using System.ComponentModel.DataAnnotations;

namespace calisanlar.DataBase
{
    public class Kisi
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
    }
}
