using ExamenPractico.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenPractico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloController : ControllerBase
    {
        private readonly IVueloService _vueloService;
        public VueloController(IVueloService vueloService)
        {
            _vueloService = vueloService;
        }

        
        [HttpGet] // Formato de Fechas recomendado: yyyy-MM-dd
        public IActionResult GetVuelosByDateRange([FromQuery] DateTime fechaInicio, [FromQuery] DateTime fechaFin)
        {
            var vuelos = _vueloService.GetVuelosByDateRange(fechaInicio, fechaFin);
            return Ok(vuelos);
        }
    }
}
