using Microsoft.Extensions.DependencyInjection;
using RycAuth.Infrastructure.Context;

namespace RycAuth.Infrastructure.Configuration;

public static class DependencyInjectionExtensions
{
    public static void AddInfrastructureDependency(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();
    }
}