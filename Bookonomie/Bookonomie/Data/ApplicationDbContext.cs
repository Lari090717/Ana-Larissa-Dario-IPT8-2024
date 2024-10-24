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
            public DbSet<User> User { get; set; }
            public DbSet<Book> Book { get; set; }
            public DbSet<Author> Author { get; set; }
            public DbSet<Genre> Genre { get; set; }
    }
}
