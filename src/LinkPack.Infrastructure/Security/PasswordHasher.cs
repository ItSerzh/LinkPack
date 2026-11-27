using LinkPack.Application.Users;
using Microsoft.AspNetCore.Identity;

namespace LinkPack.Infrastructure.Security;

internal class PasswordHashService(IPasswordHasher<object> passwordHasher) : IPasswordHashService
{
    public string Hash(string password)
    {
        return passwordHasher.HashPassword(null, password);
    }
}
