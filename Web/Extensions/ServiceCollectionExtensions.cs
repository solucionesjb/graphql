using DatabaseAccess.Contamination;
using DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjectionCustom(this IServiceCollection services, IConfiguration configuration)
        {
            DependencyInjector.RegisterServices(services);
            DependencyInjector.AddDbContext<DatabaseContext>(configuration.GetConnectionString(nameof(DatabaseContext)));
        }

    }
}
