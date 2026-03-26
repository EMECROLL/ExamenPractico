using ExamenPractico.Application.DTOs.Auth;

namespace ExamenPractico.Application.Interfaces;

public interface IAuthService
{
    bool Login(LoginDTO dto);
}
