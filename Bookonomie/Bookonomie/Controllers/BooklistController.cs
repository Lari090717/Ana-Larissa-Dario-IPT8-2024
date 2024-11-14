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
            return View();
        }
    }
}
