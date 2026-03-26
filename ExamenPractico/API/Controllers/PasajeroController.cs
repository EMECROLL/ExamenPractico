using ExamenPractico.Application.DTOs.Pasajeros;
using ExamenPractico.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamenPractico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasajeroController : ControllerBase
    {
        private readonly IPasajeroService _pasajeroService;

        public PasajeroController(IPasajeroService pasajeroService)
        {
            _pasajeroService = pasajeroService;
        }

        [HttpGet]
        public IActionResult ListarPasajeros()
        {
            var pasajeros = _pasajeroService.ListarPasajeros();
            return Ok(pasajeros);
        }

        [HttpPost]
        public IActionResult CrearPasajero([FromBody] PasajeroCreateDTO dto)
        {
            var pasajero = _pasajeroService.CrearPasajero(dto);
            return Ok(pasajero);
        }
    }
}
