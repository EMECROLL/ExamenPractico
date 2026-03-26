using ExamenPractico.Application.DTOs.Vuelos;

namespace ExamenPractico.Application.Interfaces;

public interface IVueloService
{
    bool CrearListaVuelos(List<VueloCreateDTO> vuelos);
    List<VueloDTO> GetVuelosByDateRange(DateTime fechaInicio, DateTime fechaFin);
}
