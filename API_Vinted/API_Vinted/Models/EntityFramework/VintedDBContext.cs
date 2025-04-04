﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using API_Vinted.Models.EntityFramework;

namespace API_Vinted.Models.EntityFramework
{
    public class VintedDBContext : DbContext
    {
        public VintedDBContext()
        {
        }

        public VintedDBContext(DbContextOptions<VintedDBContext> options)
        : base(options)
        {
        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.

        => optionsBuilder.EnableSensitiveDataLogging().UseNpgsql("Server=51.83.36.122;port=5432;Database=VintedDB_GRP1; uid=s212; password=vinted;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Recherche toutes les propriétés qui commencent par "Id"
                var idProperty = entity.GetProperties()
                    .FirstOrDefault(p => p.Name.StartsWith("ID") && p.ClrType == typeof(int));

                if (idProperty != null)
                {
                    modelBuilder.Entity(entity.ClrType)
                        .Property(idProperty.Name)
                        .UseIdentityColumn() // Commence à 1, incrémente de 1
                        .HasIdentityOptions(startValue: 1, incrementBy: 1); // Définit le début à 1 et incrémente de 1

                }
            }

            modelBuilder.Entity<Achat>()
               .Property(b => b.DateAchat)
               .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<Article>()
               .Property(b => b.DateAjout)
               .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<Message>()
               .Property(m => m.DateMessage)
               .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<Article>()
               .Property(b => b.NBVue)
               .HasDefaultValue(0);

            modelBuilder.Entity<Avis>()
               .Property(b => b.Automatique)
               .HasDefaultValue(false);
        }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<API_Vinted.Models.EntityFramework.Marque> Marque { get; set; } = default!;
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Caracteristique> Caracteristiques { get; set; }
        public DbSet<Couleur> Couleurs { get; set; }
        public DbSet<FormatColis> FormatColis { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Sexe> Sexes { get; set; }
        public DbSet<Langue> Langues { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<CaracteristiqueArticle> CaracteristiqueArticles { get; set; }
        public DbSet<CouleurArticle> CouleurArticles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PhotoArticle> PhotoArticles { get; set; }








    }
}
