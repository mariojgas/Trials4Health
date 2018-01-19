using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials4Health.Models;
using Microsoft.EntityFrameworkCore;

namespace Trials4Health.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Trilho> Trilhos { get; set; }
        public DbSet<Turista> Turistas { get; set; }
        public DbSet<PrimeirosSocorros> PrimeirosSocorros { get; set; }
        public DbSet<TrilhosPercorridos> trilhosPercorridos { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<Cuidados> Cuidados { get; set; }
        public DbSet<Requisitos> Requisitos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrilhosPercorridos>().ToTable("TrilhosPercorridos");

            // Primary key
            modelBuilder.Entity<TrilhosPercorridos>()
                .HasKey(bc => new { bc.ID_TrilhoPercorrido });

            modelBuilder.Entity<Trilho>()
                .HasKey(tri => tri.ID_Trilho);

            modelBuilder.Entity<Turista>()
                .HasKey(tur => tur.ID_Turista);

            modelBuilder.Entity<Cuidados>()
                .HasKey(cui => cui.ID_Cuidado);

            modelBuilder.Entity<Equipamentos>()
                .HasKey(eq => eq.ID_Equipamento);

            modelBuilder.Entity<Requisitos>()
                .HasKey(req => req.ID_Requisito);

            modelBuilder.Entity<PrimeirosSocorros>()
                .HasKey(pri => pri.ID_SOS);

            // Foreign keys
            /*modelBuilder.Entity<TrilhosPercorridos>()
                .HasOne(tp => tp.Trilhos)
                .WithMany(t => t)
                .HasForeignKey(tp => tp.ID_Trilho);

            modelBuilder.Entity<TrilhosPercorridos>()
                .HasOne(bc => bc.Turistas)
                .WithMany(c => c.trilhosPercorridos)
                .HasForeignKey(bc => bc.ID_Turista);*/

            /*
            modelBuilder.Entity<Trilho>()
                .HasMany(tri => tri.trilhosPercorridos)
                .WithOne(tp => tp.trilho)
                .HasForeignKey(tri => tri.IdTrilho);*/
        }
    }
}
/*protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // BookCategory Primary key
            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });

            // BookCategory Foreign keys
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BooksCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BooksCategories)
                .HasForeignKey(bc => bc.CategoryId);

            // Book Foreign keys
            modelBuilder.Entity<Book>()
                .HasOne(book => book.Author)
                .WithMany(author => author.Books)
                .HasForeignKey(book => book.AuthorId);
        }
*/
