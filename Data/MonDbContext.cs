using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Data
{
    public class MonDbContext : DbContext
    {
        public MonDbContext(DbContextOptions<MonDbContext> options) : base(options)
        {

        }
        public DbSet<Formation> Formations { get; set; }

        public DbSet<Avis> Avis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>()
                .Property(f => f.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Formation>().HasData(
                new
                {
                    Id = 1,
                    Nom = "Créer votre site web avec ASP.NET Core",
                    NomSeo = "asp-net-core",
                    Description = "Grace a cette formation vous saurez créer votre site web"
                },
                new { Id = 2, Nom = "Creer votre site web avec PHP", NomSeo = "php", Description = "Grace à cette formation Blah blah Blah" },
                new { Id = 3, Nom = "Devenez un pro du jardinage", NomSeo = "pro-jardinage", Description = "Apprenez a faire du jardinage" },
                new { Id = 4, Nom = "Photo Pro", NomSeo = "photo-pro", Description = "un pro de la photo, Blah blah Blah" }
                );
        }

    }
}


