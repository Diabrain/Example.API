using Example.API.Entities;

namespace Example.API.Models;

public record BookModel(int Id,string Name,long Price,int PublisherId,int AuthorId,int GenreId);

public static class ExtensionForBook
{
    public static BookModel ToModel(this Book book)
    {
        return new BookModel(book.Id, book.Name,book.Price, book.PublisherId, book.AuthorId, book.GenreId);
    }
}

