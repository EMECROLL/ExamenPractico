using System.ComponentModel.DataAnnotations;

namespace ExamenPractico.Application.DTOs.Pasajeros
{
    public class PasajeroCreateDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; } = string.Empty;
    }
}
