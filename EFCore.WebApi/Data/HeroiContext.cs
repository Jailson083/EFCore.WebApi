using EFCore.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebApi.Data
{
    public class HeroiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HeroApp;Data Source=DESKTOP-B9OTT3O\\SQLEXPRESS");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => 
            {
                entity.HasKey(e => new {e.BatalhaId, e.HeroiId});
            });
        }

        public DbSet<Heroi> Herois { get; set; }

        public DbSet<Arma> Arma { get; set; }

        public DbSet<Batalha> Batalha { get; set; }
         
        public DbSet<HeroiBatalha> HeroiBatalha { get; set; }

        public DbSet<IdentidadeSecreta> IdentidadeSecreta { get; set; }
       
    }
}
