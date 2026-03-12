using Bookonomie.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookonomie.Data.Configuration;

public class BookUserConfiguration : IEntityTypeConfiguration<BookUser>
{
    public void Configure(EntityTypeBuilder<BookUser> builder)
    {
        builder.ToTable(nameof(BookUser));

        builder.HasOne(x => x.Book)
            .WithMany(x => x.BookUsers)
            .HasForeignKey(x => x.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(x => x.BookUsers)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
