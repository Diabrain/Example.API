using Example.API.Context;
using Example.API.Entities;

namespace Example.API.Repositories;

public class AuthorRepository : GenericRepository<int, Author, AppDbContext>
{
    public AuthorRepository(AppDbContext context) : base(context)
    {

    }
}
