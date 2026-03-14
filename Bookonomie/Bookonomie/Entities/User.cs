using Microsoft.AspNetCore.Identity;

namespace Bookonomie.Entities;

public class User : IdentityUser
{
    public ICollection<BookUser> BookUsers { get; set; }
}
