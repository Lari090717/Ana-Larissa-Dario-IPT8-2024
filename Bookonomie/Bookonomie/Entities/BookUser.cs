namespace Bookonomie.Entities;

public class BookUser
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public Book Book { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }
}
