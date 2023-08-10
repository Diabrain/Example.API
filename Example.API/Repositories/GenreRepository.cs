using Example.API.Context;
using Example.API.Entities;

namespace Example.API.Repositories;

public class GenreRepository : GenericRepository<int, Genre, AppDbContext>
{
    public GenreRepository(AppDbContext context) : base(context)
    {
    }
}
