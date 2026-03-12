namespace Bookonomie.Entities;

public class BookGenre
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public int GenreId { get; set; }

    public virtual Genre Genre { get; set; } = null!;
}
