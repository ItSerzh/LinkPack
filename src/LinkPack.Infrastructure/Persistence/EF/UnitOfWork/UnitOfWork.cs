using LinkPack.Application;

namespace LinkPack.Infrastructure.Persistence.EF.UnitOfWork;

public class UnitOfWork(AppDbContext appDbContext) : IUnitOfWork
{
    public async  Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await appDbContext.SaveChangesAsync(cancellationToken);
    }
}
