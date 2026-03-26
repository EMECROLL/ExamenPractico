using ExamenPractico.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ExamenPractico.Application.DTOs.Vuelos;

public class VueloDTO
{
    [Required(ErrorMessage = "El numero de vuelo es obligatorio")]
    [StringLength(4)]
    public string NumeroVuelo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El origen es obligatorio")]
    [StringLength(2)]
    public string Origen { get; set; } = string.Empty;

    [Required(ErrorMessage = "El destion es obligatorio")]
    [StringLength(2)]
    public string Destino { get; set; } = string.Empty;
    [Required(ErrorMessage = "La fecha es obligatoria")]
    public string FechaSalida { get; set; } = string.Empty;
}
