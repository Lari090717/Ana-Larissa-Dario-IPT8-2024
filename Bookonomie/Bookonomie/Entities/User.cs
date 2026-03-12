namespace Bookonomie.Entities;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Userpassword { get; set; }

    public ICollection<BookUser> BookUsers { get; set; }
}
