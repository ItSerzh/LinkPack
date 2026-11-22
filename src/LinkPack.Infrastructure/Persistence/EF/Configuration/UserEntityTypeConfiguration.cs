using LinkPack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkPack.Infrastructure.Persistence.EF.Configuration;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.Email)
            .IsUnique();

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(p => p.PasswordHash)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(256);
    }
}
