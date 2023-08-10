namespace Example.API.Entities;

public class BaseEntity<T> where T : struct
{
    public T Id { get; set; }
}

public class BaseEntity:BaseEntity<int>
{
    public required string Name { get; set; }
}
