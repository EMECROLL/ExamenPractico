using ExamenPractico.Application.DTOs.Pasajeros;
using ExamenPractico.Domain.Entities;

namespace ExamenPractico.Application.Interfaces;

public interface IPasajeroService
{
    Pasajero CrearPasajero(PasajeroCreateDTO dto);
    bool CrearListaPasajeros(List<PasajeroCreateDTO> pasajeros);
    List<Pasajero> ListarPasajeros();
}
