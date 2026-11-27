using LinkPack.Application;
using LinkPack.Application.Users;
using LinkPack.Infrastructure.Persistence.EF;
using LinkPack.Infrastructure.Persistence.EF.Repositories;
using LinkPack.Infrastructure.Persistence.EF.UnitOfWork;
using LinkPack.Infrastructure.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LinkPack.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("PgConnection"));
        });

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();

        return services;
    }
}
