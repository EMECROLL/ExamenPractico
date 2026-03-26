using ExamenPractico.Application.DTOs.Reservaciones;
using ExamenPractico.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamenPractico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionController : ControllerBase
    {
        private readonly IReservacionService _reservacionService;

        public ReservacionController(IReservacionService reservacionService)
        {
            _reservacionService = reservacionService;
        }

        [HttpPost]
        public IActionResult CrearReservacion([FromBody] ReservacionCreateDTO dto)
        {
            _reservacionService.CrearReservacion(dto);
            return Ok(new { Exitoso = true });
        }
    }
}
