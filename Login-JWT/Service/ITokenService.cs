using Login_JWT.Models;

namespace Login_JWT.Service
{
    public interface ITokenService
    {
        /*Construye el token*/
        string BuildToken(string key, string issuer, UserDTO user);
        /*Verifica  si el token dado es válido*/
        bool IsTokenValid(string key, string issuer, string token);
    }
}
