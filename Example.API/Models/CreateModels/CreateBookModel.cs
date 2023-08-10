using Example.API.Entities;

namespace Example.API.Models.CreateModels;

public class CreateBookModel
{
    public required string Name { get; set; }
    public  long Price { get; set; }
    public int PublisherId { get; set; }
    public int AuthorId { get; set; }
    public int GenreId { get; set; }
}
