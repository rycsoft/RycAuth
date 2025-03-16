using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RycAuth.Infrastructure.Context;

namespace RycAuth.Infrastructure.Configuration;

public static class DependencyInjectionExtensions
{
    public static void AddInfrastructureDependency(this IServiceCollection services, string? dbConnectionString)
    {
        services.AddDbContext<ApplicationDbContext>
            (options => options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString)));
    }
}