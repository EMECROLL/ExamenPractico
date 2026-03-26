using ExamenPractico.Application.DTOs.Reservaciones;
using ExamenPractico.Application.Interfaces;

namespace ExamenPractico.Application.Services;

public class ReservacionService : IReservacionService
{
    private readonly IVueloService _vueloService;
    private readonly IPasajeroService _pasajeroService;

    public ReservacionService(IVueloService vueloService, IPasajeroService pasajeroService)
    {
        _vueloService = vueloService;
        _pasajeroService = pasajeroService;
    }

    public void CrearReservacion(ReservacionCreateDTO dto)
    {
        if (dto is null || dto.Vuelos is null || dto.Pasajeros is null)
        {
            throw new ArgumentException("La reservacion enviada no es valida");
        }

        var vuelosCreados = _vueloService.CrearListaVuelos(dto.Vuelos);
        var pasajerosCreados = _pasajeroService.CrearListaPasajeros(dto.Pasajeros);

        if (!vuelosCreados || !pasajerosCreados)
        {
            throw new Exception("No se pudo crear la reservacion");
        }
    }
}
