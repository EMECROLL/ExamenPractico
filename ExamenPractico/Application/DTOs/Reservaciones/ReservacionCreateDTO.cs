using ExamenPractico.Application.DTOs.Pasajeros;
using ExamenPractico.Application.DTOs.Vuelos;
using System.ComponentModel.DataAnnotations;

namespace ExamenPractico.Application.DTOs.Reservaciones;

public class ReservacionCreateDTO
{
    [Required(ErrorMessage = "La lista es obligatoria")]
    [MinLength(1, ErrorMessage = "La lista no puede estar vacia")]
    public List<VueloCreateDTO> Vuelos { get; set; } = new ();

    [Required(ErrorMessage = "La lista es obligatoria")]
    [MinLength(1, ErrorMessage = "La lista no puede estar vacia")]
    public List<PasajeroCreateDTO>? Pasajeros { get; set; } = new();
}
