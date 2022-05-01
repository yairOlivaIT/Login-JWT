using Login_JWT.Models;

namespace Login_JWT.Service
{
    public interface IUserService
    {
        UserDTO GetUser(UserModel userMode);

    }
}
