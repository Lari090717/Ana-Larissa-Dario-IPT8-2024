using Bookonomie.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookonomie.Data.Configuration;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable(nameof(Author));

        builder.HasMany(x => x.Books)
            .WithOne(x => x.Author)
            .HasForeignKey(x => x.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
