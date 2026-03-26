using ExamenPractico.Application.DTOs.Auth;
using ExamenPractico.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamenPractico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO dto)
        {
            var autorice = _authService.Login(dto);
            return Ok(new { Autorice = autorice });
        }
    }
}
