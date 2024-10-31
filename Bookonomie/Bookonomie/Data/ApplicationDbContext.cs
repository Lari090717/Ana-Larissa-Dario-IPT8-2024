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
            public DbSet<Book> Books { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Genre> Genres { get; set; }
            public DbSet<BookGenre> BookGenres { get; set; }
    }
}
