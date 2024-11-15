using Bookonomie.Data;
using Bookonomie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            searchInput = Request.Form["query"]; //Gets value from the input field
            if (string.IsNullOrEmpty(searchInput)) //If input empty -> return all books
                return View(books);

            books = _context.Book.Where(b => b.Title.Contains(searchInput)).ToList(); //search books and make them into a list so you can find multiple books
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


         public async Task<IActionResult> AddBookToList(int bookId, int userId)
        {
            // Check if the book is already in list
            userId = 1;
            var bookList = await _context.BookUser.FirstOrDefaultAsync(bu => bu.fk_BookId == bookId && bu.fk_UserId == userId);
            if (bookList == null)
            {
                var addNewBookUser = new BookUser
                {
                    fk_BookId = bookId,
                    fk_UserId = userId,
                };
                _context.BookUser.Add(addNewBookUser);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
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
                .Select(b => new
                {
                    title = b.Title,
                    rating = b.Rating,
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
