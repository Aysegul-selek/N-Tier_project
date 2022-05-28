using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concreate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LITKJC6;database=CoreProject;integrated security=true;");

        }
        public DbSet<Marka> MArkas { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
    }
}
