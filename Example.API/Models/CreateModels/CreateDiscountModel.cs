using Example.API.Entities;

namespace Example.API.Models.CreateModels;

public class CreateDiscountModel
{
    public int? PublisherId { get; set; }
    public int? AuthorId { get; set; }
    public int? BookId { get; set; }
    public long Percantage { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime EndDate { get; set; }
}
