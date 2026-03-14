namespace Bookonomie.Models;

public class BookAuthorGenreModel
{
    public BookModel BookModel { get; set; }

    public AuthorModel AuthorModel { get; set; }

    public GenreModel GenreModel { get; set; }
}
