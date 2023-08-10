using Example.API.Entities;

namespace Example.API.Models;

public record DiscountModel(int Id,long Percantage, int? PublisherId, int? AuthorId, int? BookId);

public static class ExtensionForDiscount
{
    public static DiscountModel ToModel(this Discount discount)
    {
        return new DiscountModel(
            discount.Id,
            discount.Percantage,
            discount.PublisherId,
            discount.AuthorId,
            discount.BookId
            );
    }
}

