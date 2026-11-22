using LinkPack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkPack.Infrastructure.Persistence.EF.Configuration;

public class LinkEntityTypeConfiguration : IEntityTypeConfiguration<Link>
{
    public void Configure(EntityTypeBuilder<Link> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.Code)
            .IsUnique();

        builder.Property(p => p.Code)
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(p => p.OriginalUrl)
            .IsRequired()
            .HasMaxLength(2048);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

    }
}
