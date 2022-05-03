using Login_JWT.Models;
using System.Collections.Generic;
using System.Linq;

namespace Login_JWT.Service.Implementaciones
{
    /*Amplía la IUserService interfaz e implementa el GetUsermétodo.
     *También contiene los datos de muestra utilizados por la aplicación como una lista de la UserDTOclase.*/
    /* La aplicación aprovecha la instancia del repositorio para realizar operaciones CRUD 
     * en la base de datos. En este ejemplo, el HomeController interactúa con el UserService 
     * para recuperar un usuario basado en el nombre de usuario y la contraseña.*/
    /* La UserService clase extiende la IUserService interfaz e implementa el GetUser método,
     * También construye una lista de UserDTO objetos.*/
    public class UserService : IUserService
    {
        private readonly List<UserDTO> users = new List<UserDTO>();

        public UserService()
        {
            users.Add(new UserDTO { Username = "Alberto", Password = "123", Role = "manager" });
            users.Add(new UserDTO { Username = "Federico", Password = "456", Role = "admin" });
            users.Add(new UserDTO { Username = "Lucas", Password = "789", Role = "developer" });
            users.Add(new UserDTO { Username = "Maximiliano", Password = "012", Role = "tester" });

        }
        public UserDTO GetUser(UserModel userModel)
        {
            return users.Where(x => x.Username.ToLower() == userModel.Username.ToLower()
                && x.Password == userModel.Password).FirstOrDefault();
        }
    }
}
