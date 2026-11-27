using LinkPack.Application.Users;
using LinkPack.Domain.Entities;

namespace LinkPack.Infrastructure.Persistence.EF.Repositories
{
    public class UserRepository(AppDbContext appDbContext) : IUserRepository
    {
        public async Task CreateAsync(User user, CancellationToken cancellationToken = default)
        {
            await appDbContext.Users.AddAsync(user, cancellationToken);
        }
    }
}
