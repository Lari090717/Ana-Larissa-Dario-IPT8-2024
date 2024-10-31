using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookonomie.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Authorname { get; set; }

        // Navigation property for the related Books
        public ICollection<Book> Books { get; set; }
    }
}
