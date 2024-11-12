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
            var books = _context.Book.ToList();
             return View(books);
        }

        [HttpPost]
        public IActionResult Index(string searchInput)
        {
            var books = _context.Book.ToList();
            searchInput = Request.Form["query"];
            if (string.IsNullOrEmpty(searchInput))
                return View(books);

            books = _context.Book.Where(b => b.Title.Contains(searchInput)).ToList();
            return View(books);
        }

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
        public IActionResult GetBookDetails(int id)
        {
            var book = _context.Book
                .Where(b => b.BookId == id)
                .Select(b => new {
                    title = b.Title,
                    rating = b.Rating,
                    author = b.Author,
                    description = b.Description
                })
                .FirstOrDefault();

            if (book == null)
            {
                return NotFound();
            }

            return Json(book);
        }
    }
}
