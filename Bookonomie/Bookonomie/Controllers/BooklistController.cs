using Bookonomie.Data;
using Bookonomie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace Bookonomie.Controllers
{
    public class BooklistController:Controller
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
        public IActionResult Booklist()
        {
            List<Book> books = new List<Book>();

            int userId = 1; //If login works remove this line!
            var bookUser = _context.BookUser.Where(u => u.fk_UserId == userId).ToList(); //Get personal list of user
            foreach(var book in bookUser)
            {
                var bookFromList = _context.Book.FirstOrDefault(b => b.BookId == book.fk_BookId); //Get each book from the BookUser list with the foreign key
                if (bookFromList != null)
                    books.Add(bookFromList); //Put every book of personal list in a book-list instead of BookUser
            }
            return View(books);
        }
    }
}
