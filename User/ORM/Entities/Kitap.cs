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
    internal class Kitap
    {
        public int Id { get; set; }
        
        public string KitapAdi{ get; set; }
        public string KitabinYazari { get; set; }
        public string KitabinYayinEvi { get; set; }
        
       
    }
}
