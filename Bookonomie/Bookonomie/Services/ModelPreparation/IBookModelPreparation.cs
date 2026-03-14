using Bookonomie.Data;
using Bookonomie.Models;

namespace Bookonomie.Services.ModelPreparation;

public interface IBookModelPreparation
{
    Task<BookModel> PrepareBookModelAsync(BookonomieContext dbContext, int bookId);

    Task<List<BookModel>> PrepareUserBookModelListAsync(BookonomieContext dbContext, string userId);

    Task<List<BookModel>> GetAllBookModelsAsync(BookonomieContext dbContext);

}