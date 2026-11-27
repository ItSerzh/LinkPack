using LinkPack.Domain.Entities;

namespace LinkPack.Application.Users;

public interface IUserRepository
{
    Task CreateAsync(User user, CancellationToken cancellationToken = default);
}
