using ExamenPractico.Application.Interfaces;
using ExamenPractico.Application.DTOs.Auth;

namespace ExamenPractico.Application.Services
{
	public class AuthService : IAuthService
	{
		private readonly IDataService _dataService;

		public AuthService(IDataService dataService)
		{
			_dataService = dataService;
		}

		public bool Login(LoginDTO dto)
		{
			var userExists = _dataService.Usuarios.Any(x =>
				x.Username == dto.Username && x.Password == dto.Password);

			return userExists;
		}
	}
}
