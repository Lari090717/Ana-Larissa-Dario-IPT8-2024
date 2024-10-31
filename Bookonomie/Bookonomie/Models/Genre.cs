using System.ComponentModel.DataAnnotations;

namespace Bookonomie.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Genrename { get; set; }

        // Navigation property for BookGenre many-to-many relationship
        public ICollection<Book> Books { get; set; }
    }
}
