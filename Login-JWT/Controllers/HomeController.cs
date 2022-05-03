using Login_JWT.Models;
using Login_JWT.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace JWTASPNetCore.Controllers
{
    /* En la HomeController clase, aprovechará la inserción de dependencias para poder usar instancias
     * de las clases Configuration, TokenService y UserService. Cree las siguientes instancias de solo
     * lectura para cada una de las tres interfaces*/
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;

        /*Así es como se usa la inyección de constructor en la HomeController clase
         *para cada una de las instancias discutidas anteriormente.*/
        public HomeController(IConfiguration config, ITokenService tokenService, IUserService userRepository)
        {
            _config = config;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        public IActionResult Login(UserModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.Username) || string.IsNullOrEmpty(userModel.Password))
            {
                return (RedirectToAction("Error"));
            }

            IActionResult response = Unauthorized();
            var validUser = GetUser(userModel);

            var Key = _config["Jwt:Key"].ToString();
            var Issuer = _config["Jwt:Issuer"].ToString();

            if (validUser != null)
            {
                generatedToken = _tokenService.BuildToken(Key,Issuer,validUser);

                if (generatedToken != null)
                {
                    HttpContext.Session.SetString("Token", generatedToken);
                    return RedirectToAction("MainWindow");
                }
                else
                {
                    return (RedirectToAction("Error"));
                }
            }
            else
            {
                return (RedirectToAction("Error"));
            }
        }
        /*El GetUser método de la HomeController clase llama al GetUser método de la UserService
         *clase para recuperar una instancia de la UserDTO clase en función de las credenciales de 
         *usuario ingresadas en la pantalla de inicio de sesión.*/
        private UserDTO GetUser(UserModel userModel)
        {
            //Write your code here to authenticate the user
            return _userRepository.GetUser(userModel);
        }

        [Authorize]
        [Route("mainwindow")]
        [HttpGet]
        public IActionResult MainWindow()
        {
            string token = HttpContext.Session.GetString("Token");

            if (token == null)
            {
                return (RedirectToAction("Index"));
            }

            if (!_tokenService.IsTokenValid(_config["Jwt:Key"].ToString(),
                _config["Jwt:Issuer"].ToString(), token))
            {
                return (RedirectToAction("Index"));
            }

            ViewBag.Message = BuildMessage(token, 35);
            return View();
        }

        public IActionResult Error()
        {
            ViewBag.Message = "Credenciales inválidas...";
            return View();
        }

        /* El BuildMessage método se utiliza para dividir el token generado en varias líneas. */
        private string BuildMessage(string stringToSplit, int chunkSize)
        {
            var data = Enumerable.Range(0, stringToSplit.Length / chunkSize)
                .Select(i => stringToSplit.Substring(i * chunkSize, chunkSize));

            string result = "Token generado:";

            foreach (string str in data)
            {
                result += Environment.NewLine + str;
            }

            return result;
        }
    }
}
