using ExamenPractico.Application.DTOs.Reservaciones;

namespace ExamenPractico.Application.Interfaces;

public interface IReservacionService
{
    void CrearReservacion(ReservacionCreateDTO dto);
}
