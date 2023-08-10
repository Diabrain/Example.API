namespace Example.API.Entities;

public class Genre:BaseEntity
{
    public List<Book>? Books { get; set; }
    
}
