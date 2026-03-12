namespace Bookonomie.Entities;

public class Author
{
    public int Id { get; set; }

    public string Authorname { get; set; }

    public ICollection<Book> Books { get; set; }
}
