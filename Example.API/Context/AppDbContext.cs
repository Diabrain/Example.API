using Example.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Context;

public class AppDbContext:DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
}
