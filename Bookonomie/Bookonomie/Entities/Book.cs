namespace Bookonomie.Entities;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public double? Rating { get; set; }

    public int ReleaseYear { get; set; }

    public int AuthorId { get; set; }

    public Author Author { get; set; }

    public ICollection<BookGenre> BookGenres { get; set; }

    public ICollection<BookUser> BookUsers { get; set; }
}
