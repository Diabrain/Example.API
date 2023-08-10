using Example.API.Entities;

namespace Example.API.Models;

public record PublisherModel(int Id, string Name, List<BookModel> Books, List<DiscountModel> Discounts);

public static class EntensionPublish
{

    public static PublisherModel ToModel(this Publisher entity)
    {
        var books = new List<BookModel>();
        var discounts = new List<DiscountModel>();
        if (entity.Discounts is not null)
        {
            discounts = entity.Discounts.Select(s => s.ToModel()).ToList();
        }
        if (entity.Books is not null)
        {
            books = entity.Books.Select(s => s.ToModel()).ToList();
        }
        return new PublisherModel(
            entity.Id,
            entity.Name,
            books,
            discounts);

    }
}
