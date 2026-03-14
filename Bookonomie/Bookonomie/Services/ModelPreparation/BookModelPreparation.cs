using Bookonomie.Data;
using Bookonomie.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookonomie.Services.ModelPreparation;

public class BookModelPreparation : IBookModelPreparation
{
    public async Task<BookModel> PrepareBookModelAsync(BookonomieContext dbContext, int bookId)
    {
        var book = await dbContext.Books.SingleAsync(x => x.Id == bookId);

        var model = new BookModel
        {
            Id = bookId,
            Title = book.Title,
            Description = book.Description,
            Rating = book.Rating,
            ReleaseYear = book.ReleaseYear,
        };

        return model;
    }

    public async Task<List<BookModel>> PrepareUserBookModelListAsync(BookonomieContext dbContext, string userId)
    {
        List<BookModel> bookModelList = [];
        var bookIds = await dbContext.BookUsers.Where(x => x.UserId == userId).Select(x => x.BookId).ToListAsync();

        foreach (var bookId in bookIds)
        {
            var book = await dbContext.Books.SingleAsync(x => x.Id == bookId);

            var bookModel = new BookModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Rating = book.Rating,
                ReleaseYear = book.ReleaseYear,
            };

            bookModelList.Add(bookModel);
        }

        return bookModelList;
    }

    public async Task<List<BookModel>> GetAllBookModelsAsync(BookonomieContext dbContext)
    {
        List<BookModel> bookModelList = [];

        var bookList = await dbContext.Books.ToListAsync();
        foreach (var book in bookList)
        {
            var bookModel = new BookModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Rating = book.Rating,
                ReleaseYear = book.ReleaseYear,
            };

            bookModelList.Add(bookModel);
        }

        return bookModelList;
    }
}
