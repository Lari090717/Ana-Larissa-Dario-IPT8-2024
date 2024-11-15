using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bookonomie.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Userpassword { get; set; }

        // Navigation property for BookGenre many-to-many relationship
        public ICollection<BookUser> BookUser { get; set; }
    }
}
