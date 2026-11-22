using LinkPack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinkPack.Infrastructure.Persistence.EF;

internal class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public DbSet<Link> Links { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
