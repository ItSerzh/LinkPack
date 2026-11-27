using LinkPack.Domain.Entities;

namespace LinkPack.Application.Users;

public interface IPasswordHashService
{
    string Hash(string password);
}
