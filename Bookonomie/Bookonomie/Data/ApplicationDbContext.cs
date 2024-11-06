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
            public DbSet<User> Users { get; set; }
            public DbSet<Book> Book { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Genre> Genres { get; set; }
            //public DbSet<BookGenre> BookGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Genres)
                .WithMany(g => g.Books)
                .UsingEntity(j => j.ToTable("BookGenre")); // Optional: Specify the table name
        }

    }
}
