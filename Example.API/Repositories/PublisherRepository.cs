using Example.API.Context;
using Example.API.Entities;

namespace Example.API.Repositories;

public class PublisherRepository : GenericRepository<int, Publisher, AppDbContext>
{
    public PublisherRepository(AppDbContext context) : base(context) { }
}




