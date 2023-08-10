using Example.API.Entities;

namespace Example.API.Models;

public record GenreModel(int Id, string Name, List<BookModel> Books);

public static class EntensionGenre
{ 
    public static GenreModel ToModel(this Genre entity)
    {
        var books = new List<BookModel>();
       
        if (entity.Books is not null)
        {
            books = entity.Books.Select(s => s.ToModel()).ToList();
        }
        return new GenreModel(
            entity.Id,
            entity.Name,
            books
            );
    }
}

