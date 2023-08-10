namespace Example.API.Entities;

public class Publisher:BaseEntity
{
    public List<Discount>? Discounts { get; set; }
    public List<Book>? Books { get; set; }
}
