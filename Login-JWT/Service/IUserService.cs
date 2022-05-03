using Login_JWT.Models;

namespace Login_JWT.Service
{
    public interface IUserService
    {
        /*Esta interfaz contiene la declaración del GetUser método que se usa para obtener una UserDTO 
         * instancia basada en el nombre de usuario de una instancia de UserModel clase.*/
        UserDTO GetUser(UserModel userMode);

    }
}
