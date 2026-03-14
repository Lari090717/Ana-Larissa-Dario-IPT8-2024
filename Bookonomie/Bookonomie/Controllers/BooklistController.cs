using Bookonomie.Data;
using Bookonomie.Services.ModelPreparation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookonomie.Controllers;

[Route("[controller]")]
public class BooklistController(IDbContextFactory<BookonomieContext> dbContextFactory, IBookModelPreparation bookModelPreparation) : Controller
{
    [HttpGet("bookId")]
    public async Task<IActionResult> GetBookDetails(int id)
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();

        var book = await bookModelPreparation.PrepareBookModelAsync(dbContext, id);

        return Json(book);
    }
    public async Task<IActionResult> Booklist()
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();

        var userId = "1"; //If login works remove this line!
        var books = await bookModelPreparation.PrepareUserBookModelListAsync(dbContext, userId);

        return View(books);
    }
}
