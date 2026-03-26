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
            try
            {
                var creado = _reservacionService.CrearReservacion(dto);

                if (!creado)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "No se pudo crear la reservacion");
                }

                return Ok(new { Exitoso = true });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
