namespace Bookonomie.Entities;

public class Genre
{
    public int GenreId { get; set; }

    public string Genrename { get; set; }

    public ICollection<BookGenre> BookGenres { get; set; }
}
