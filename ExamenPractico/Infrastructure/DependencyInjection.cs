using ExamenPractico.Application.Interfaces;
using ExamenPractico.Infrastructure.Persistence.InMemory;
using Microsoft.Extensions.DependencyInjection;

namespace ExamenPractico.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IDataService, DataService>();
        return services;
    }
}
