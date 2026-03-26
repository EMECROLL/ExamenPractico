using ExamenPractico.Application.DTOs.Reservaciones;

namespace ExamenPractico.Application.Interfaces;

public interface IReservacionService
{
    bool CrearReservacion(ReservacionCreateDTO dto);
}
