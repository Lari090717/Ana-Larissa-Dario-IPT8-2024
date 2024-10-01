using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bookonomie.Controllers
{
    [Route("[controller]")]
    public class FilterController : Controller
    {
        // Simulierter Datensatz von Büchern (mit Genre und Rating)
        private static List<Book> books = new List<Book>
        {
            new Book { Title = "The Great Gatsby", Genre = "Classic", Rating = 5 },
            new Book { Title = "To Kill a Mockingbird", Genre = "Classic", Rating = 4 },
            new Book { Title = "1984", Genre = "Science Fiction", Rating = 5 },
            new Book { Title = "The Catcher in the Rye", Genre = "Classic", Rating = 3 },
            new Book { Title = "Moby Dick", Genre = "Adventure", Rating = 4 }
        };

        // GET: Filter
        [HttpGet("[action]")]
        public IActionResult Filter(string filterType, string genre, int? rating)
        {
            var filteredBooks = books.AsQueryable();

            // Genre-Filter
            if (!string.IsNullOrEmpty(filterType))
            {
                if (filterType == "genre" && !string.IsNullOrEmpty(genre))
                {
                    filteredBooks = filteredBooks.Where(b => b.Genre.ToLower() == genre.ToLower());
                }
                // Rating-Filter
                else if (filterType == "rating" && rating.HasValue)
                {
                    filteredBooks = filteredBooks.Where(b => b.Rating == rating);
                }
            }

            // Die verfügbaren Genres für das Genre-Dropdown
            ViewBag.Genres = new List<string> { "Classic", "Science Fiction", "Adventure" };
            ViewBag.FilteredBooks = filteredBooks.ToList();
            ViewBag.SelectedFilter = filterType;

            return View();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Genre { get; set; }
            public int Rating { get; set; }
        }
    }
}
