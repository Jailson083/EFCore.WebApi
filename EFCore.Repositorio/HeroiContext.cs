using EFCore.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositorio
{
    public class HeroiContext : DbContext
    {
        public HeroiContext(DbContextOptions<HeroiContext> options) : base(options) { }
        public DbSet<Heroi> Herois { get; set; }

        public DbSet<Arma> Arma { get; set; }

        public DbSet<Batalha> Batalha { get; set; }

        public DbSet<HeroiBatalha> HeroiBatalha { get; set; }

        public DbSet<IdentidadeSecreta> IdentidadeSecreta { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity =>
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }

    }
}       
       
