using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bookonomie.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double? Rating { get; set; }

        public int ReleaseYear { get; set; }

        // Foreign key for Author
        [ForeignKey("Author")]
        public int fk_AuthorId { get; set; }
        public Author Author { get; set; }

        // Navigation property for BookGenre many-to-many relationship
        public ICollection<Genre> Genres { get; set; }
    }
}
