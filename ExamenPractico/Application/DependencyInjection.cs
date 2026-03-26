using ExamenPractico.Application.Services;
using ExamenPractico.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ExamenPractico.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IVueloService, VueloService>();
        services.AddScoped<IPasajeroService, PasajeroService>();
        services.AddScoped<IReservacionService, ReservacionService>();
        return services;
    }
}
