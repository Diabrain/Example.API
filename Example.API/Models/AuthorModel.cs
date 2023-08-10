using Example.API.Entities;

namespace Example.API.Models;

public record AuthorModel(int Id,string Name,List<BookModel> Books,List<DiscountModel> Discounts);

public static class EntensionAuthor
{

    public static AuthorModel ToModel(this Author entity)
    {
        var books = new List<BookModel>();
        var discounts = new List<DiscountModel>();
        if(entity.Discounts is not null)
        {
            discounts = entity.Discounts.Select(s => s.ToModel()).ToList();
        }
        if(entity.Books is not null)
        {
            books = entity.Books.Select(s => s.ToModel()).ToList();
        }
        return new AuthorModel(
            entity.Id,
            entity.Name,
            books,
            discounts);
            
    }
}

