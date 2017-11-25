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
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Trilho> Trilhos { get; set; }
        public DbSet<Turista> Turistas { get; set; }
        public DbSet<SOS> PrimeirosSocorros { get; set; }
        public DbSet<TrilhosPercorrido> trilhosPercorrido { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<Cuidados> Cuidados { get; set; }
        public DbSet<Requisitos> Requisitos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BookCategory Primary key
            modelBuilder.Entity<TrilhosPercorrido>()
                .HasKey(bc => new { bc.IdTrilho,bc.IdTurista });

            // BookCategory Foreign keys
            modelBuilder.Entity<TrilhosPercorrido>()
                .HasOne(bc => bc.trilho)
                .WithMany(b => b.trilhosPercorrido)
                .HasForeignKey(bc => bc.IdTrilho);

            modelBuilder.Entity<TrilhosPercorrido>()
                .HasOne(bc => bc.turista)
                .WithMany(c => c.trilhosPercorridos)
                .HasForeignKey(bc => bc.IdTurista);

           
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