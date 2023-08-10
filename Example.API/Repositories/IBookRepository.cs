using Example.API.Entities;
using Example.API.Models;

namespace Example.API.Repositories;

public interface IBookRepository
{
    //Task<List<BookModel>> GetBookWithBookFilter(BookFilter filter);
    Task<Book> GetBook(Book book);
}
