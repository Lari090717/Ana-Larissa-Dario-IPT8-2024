using Bookonomie.Data;
using Bookonomie.Entities;
using Bookonomie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bookonomie.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ApplicationDbContext _context;

        public LoginController(ILogger<LoginController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
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

            // Query the database for the user
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Userpassword == password);

            if (user != null)
            {
                // Successful login
                return RedirectToAction("Index", "Home");
            }

            // Failed login
            ViewBag.ErrorMessage = "Invalid login attempt.";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Both Username and Password are required.";
                return View();
            }

            // Check if the username already exists
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (existingUser != null)
            {
                ViewBag.ErrorMessage = "Username already exists. Please choose a different username.";
                return View();
            }

            // Create a new user
            var user = new User
            {

                Username = username,
                Userpassword = password // In a real app, hash the password before saving
            };

            // Add the user to the database
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Redirect to login after successful registration
            return RedirectToAction("Login", "Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
