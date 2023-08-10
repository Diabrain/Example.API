namespace Example.API.Entities;

public class Book : BaseEntity
{
    public long Price { get; set; }
    public int PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }
    
}
