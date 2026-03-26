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

        
        [HttpGet] // Formato de Fechas: dd/MM/yyyy
        public IActionResult GetVuelosByDateRange([FromQuery] string fechaInicio, [FromQuery] string fechaFin)
        {
            try
            {
                var vuelos = _vueloService.GetVuelosByDateRange(fechaInicio, fechaFin);
                return Ok(vuelos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
