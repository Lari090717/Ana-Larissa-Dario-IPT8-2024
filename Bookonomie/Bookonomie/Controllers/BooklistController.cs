using Bookonomie.Data;
using Bookonomie.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookonomie.Controllers
{
    public class BooklistController : Controller
    {
        private readonly ILogger<BooklistController> _logger;
        private readonly ApplicationDbContext _context;


        public BooklistController(ILogger<BooklistController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }
        public IActionResult GetBookDetails(int id)
        {
            var book = _context.Books
                .Where(b => b.Id == id)
                .Select(b => new
                {
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
        public IActionResult Booklist()
        {
            List<BookModel> books = new List<BookModel>();

            int userId = 1; //If login works remove this line!
            var userBooks = _context.BookUsers.Where(u => u.UserId == userId).ToList(); //Get personal list of user
            foreach (var book in userBooks)
            {
                var bookFromList = _context.Books.FirstOrDefault(b => b.Id == book.BookId); //Get each book from the BookUser list with the foreign key
                var bookModel = new BookModel();
                if (bookFromList != null)
                {
                    bookModel = new BookModel
                    {
                        Id = bookFromList.Id,
                        Title = bookFromList.Title,
                        Description = bookFromList.Description,
                        Rating = bookFromList.Rating,
                        ReleaseYear = bookFromList.ReleaseYear,
                    };
                }
                books.Add(bookModel); //Put every book of personal list in a book-list instead of BookUser
            }
            return View(books);
        }
    }
}
