using Library.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ORM.Entities
{
    internal class Kullanıcı
    {
        public int Id { get; set; }
        [Required]
        public string Ad{ get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string KullanıcıAdı { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public string Adres { get; set; }
        public bool IsAdmin { get; set; }
       
    }
}
