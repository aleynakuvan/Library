using Library.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.ORM.Context
{
    internal class Projectcontext : DbContext
    {
        public Projectcontext() : base("Server=MSI\\SQLEXPRESS;Database=Library;Integrated Security=true")

        {
            
            
        }
        public DbSet<Kullanıcı> Kullanıcıs { get; set; }
        public DbSet<Kitap>Kitaps { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Projectcontext>(null);
            base.OnModelCreating(modelBuilder);
        }
      
    }
}
