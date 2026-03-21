namespace Bookonomie.Models;

public class BookModel
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public double? Rating { get; set; }

    public int ReleaseYear { get; set; }

    public bool IsPartOfBooklist { get; set; }
}
