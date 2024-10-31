using System.ComponentModel.DataAnnotations.Schema;

namespace Bookonomie.Models
{
    public class BookGenre
    {
        [ForeignKey("Book")]
        public int fk_BookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey("Genre")]
        public int fk_GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
