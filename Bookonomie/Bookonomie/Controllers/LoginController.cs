using Bookonomie.Models;
using Bookonomie.Views.Login;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bookonomie.Controllers
{
    public class LoginController: Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Both Username and Password are required.";
                return View();
            }

            // Simuliere Login-Überprüfung (kann später durch eine echte Datenbanküberprüfung ersetzt werden)
            if (username == "admin" && password == "password")
            {
                // Erfolgreicher Login
                return RedirectToAction("Index", "Home");
            }

            // Fehlgeschlagener Login
            ViewBag.ErrorMessage = "Invalid login attempt.";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Both Username and Password are required.";
                return View();
            }

            // Hier würdest du den Benutzer speichern und ggf. überprüfen, ob der Benutzername existiert.
            // Simulierter erfolgreicher Registrierungsvorgang:
            return RedirectToAction("Login", "Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
