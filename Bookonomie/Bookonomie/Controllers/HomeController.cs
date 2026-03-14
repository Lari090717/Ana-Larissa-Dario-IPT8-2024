using Bookonomie.Data;
using Bookonomie.Models;
using Bookonomie.Services.ModelPreparation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bookonomie.Controllers;

public class HomeController(IDbContextFactory<BookonomieContext> dbContextFactory, IBookModelPreparation bookModelPreparation) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();
        var books = await bookModelPreparation.GetAllBookModelsAsync(dbContext);

        return View(books);
    }

    [HttpPost]
    public async Task<IActionResult> Index(string searchInput)
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();
        var books = await bookModelPreparation.GetAllBookModelsAsync(dbContext); //ToDo: Implement search

        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }


    public async Task<IActionResult> AddBookToList(int bookId, string userId)
    {
        //userId = "1"; //If login works remove this line!
        ////Check if the book is already in list
        //var bookList = await _context.BookUsers.FirstOrDefaultAsync(bu => bu.BookId == bookId && bu.UserId == userId);
        //if (bookList == null)
        //{
        //    //ToDo: Refactor ALL logic into services to split everything into proper layers
        //    var addNewBookUser = new BookUser
        //    {
        //        BookId = bookId,
        //        UserId = userId,
        //    };
        //    _context.BookUsers.Add(addNewBookUser);
        //    await _context.SaveChangesAsync();
        //}
        //else
        //{
        //    ViewBag.ErrorMessage = "Book is already in list";
        //    return RedirectToAction("Index");
        //}

        //ToDo: Add IsFavourite or IsInBookList Boolean to implement this
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<IActionResult> GetBookDetails(int id)
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();
        var book = await bookModelPreparation.PrepareBookModelAsync(dbContext, id);

        if (book == null)
        {
            return NotFound();
        }

        return Json(book);
    }

}
