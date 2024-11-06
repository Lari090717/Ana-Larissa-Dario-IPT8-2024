using Bookonomie.Data;
using Bookonomie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bookonomie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var bookTitles = _context.Book.Select(book => book.Title).ToList();

            return View(bookTitles);
        }

        //[HttpGet]
        //public IActionResult SelectAllBooks()
        //{

        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
