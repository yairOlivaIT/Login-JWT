namespace Login_JWT.Models
{
    /*El UserDTO representa el objeto de transferencia de datos del usuario */
    public class UserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
