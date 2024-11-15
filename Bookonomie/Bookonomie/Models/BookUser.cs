namespace Bookonomie.Models
{
    public class BookUser
    {
        public int fk_BookId { get; set; }
        public Book Book { get; set; }

        public int fk_UserId { get; set; }
        public User User { get; set; }
    }
}
