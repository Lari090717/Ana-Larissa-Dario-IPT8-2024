using Bookonomie.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookonomie.Data
{
    public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            // Definiere deine DbSets (Tabellen) hier
            public DbSet<User> BookonomieUser { get; set; }
            public DbSet<Book> Book { get; set; }
            public DbSet<Author> Author { get; set; }
            public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Genres)
                .WithMany(g => g.Books)
                .UsingEntity(j => j.ToTable("BookGenre"));

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Users)
                .WithMany(g => g.Books)
                .UsingEntity(j => j.ToTable("BookUser"));
        }

    }
}
