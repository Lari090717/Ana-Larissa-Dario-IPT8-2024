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
            public DbSet<BookUser> BookUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Genres)
                .WithMany(g => g.Books)
                .UsingEntity(j => j.ToTable("BookGenre"));

            modelBuilder.Entity<BookUser>()
                .HasKey(bu => new { bu.fk_BookId, bu.fk_UserId });

            modelBuilder.Entity<BookUser>()
                .HasOne(bu => bu.Book)
                .WithMany(b => b.BookUser)
                .HasForeignKey(bu => bu.fk_BookId);

            modelBuilder.Entity<BookUser>()
                .HasOne(bu => bu.User)
                .WithMany(u => u.BookUser)
                .HasForeignKey(bu => bu.fk_UserId);
        }

    }
}
