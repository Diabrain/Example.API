using Example.API.Context;
using Example.API.Entities;

namespace Example.API.Repositories;

public class DiscountRepository : GenericRepository<int, Discount, AppDbContext>
{
    public DiscountRepository(AppDbContext context) : base(context)
    {
    }
}
