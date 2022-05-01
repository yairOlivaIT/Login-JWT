using Login_JWT.Models;
using System.Collections.Generic;
using System.Linq;

namespace Login_JWT.Service.Implementaciones
{
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
