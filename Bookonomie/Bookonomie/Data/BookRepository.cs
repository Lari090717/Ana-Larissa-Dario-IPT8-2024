using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Bookonomie.Data;
using Bookonomie.Models;

namespace Bookonomie.Data
{
    public class BookRepository
    {
        private readonly ApplicationDbContext _context;

        public Book GetBookById(int id)
        {
            return _context.Books.Include(b => b.Author).Include(b => b.Genres)
            .FirstOrDefault(b => b.BookId == id);
        }
    }
}
