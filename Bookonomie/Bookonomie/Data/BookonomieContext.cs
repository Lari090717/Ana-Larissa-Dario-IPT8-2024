using Bookonomie.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bookonomie.Data;

public class BookonomieContext : IdentityDbContext<User>
{
    public BookonomieContext(DbContextOptions<BookonomieContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<BookUser> BookUsers { get; set; }
    public DbSet<BookGenre> BookGenres { get; set; }
}
