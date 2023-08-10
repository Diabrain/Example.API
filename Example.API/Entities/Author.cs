namespace Example.API.Entities;

public class Author:BaseEntity
{
    public List<Discount>? Discounts { get; set; }
    public List<Book>? Books { get; set; }
}
