namespace Example.API.Entities;

public class Discount: BaseEntity<int>
{
    public int? PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
    public int? AuthorId { get; set; }
    public Author? Author { get; set; }
    public int? BookId { get; set; }
    public Book? Book { get; set; }
    public long Percantage { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime EndDate { get; set; }
}

