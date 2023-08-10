using Example.API.Context;
using Example.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Repositories;

public class BookRepository : GenericRepository<int, Book, AppDbContext>,IBookRepository
{
    private readonly AppDbContext _context;
    public BookRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Book> GetBook(Book book)
    {
        var discounts = _context.Discounts.AsQueryable();
        discounts = discounts.Where(a => a.BookId != null && a.BookId == book.Id);
        discounts = discounts.Where(b => b.PublisherId != null && b.PublisherId == book.PublisherId);
        discounts = discounts.Where(c => c.AuthorId != null && c.AuthorId == book.AuthorId);
        var discountList = await discounts.ToListAsync();
        var discountMax = discounts.Select(s => s.Percantage).Max();
        book.Price =(100 - discountMax)*book.Price/100;
        return book;
    }

    //public async Task<List<BookModel>> GetBookWithBookFilter(BookFilter filter)
    //{
    //    var books = await _context.Books.ToListAsync();
    //    var discounts =  _context.Discounts.AsQueryable();
    //    foreach(var book in books)
    //    {
    //        discounts = discounts.Where(a => a.BookId != null && a.BookId == book.Id);
    //        discounts = discounts.Where(b => b.PublisherId != null&& b.PublisherId == book.PublisherId);
    //        discounts = discounts.Where(c => c.AuthorId != null && c.AuthorId == book.AuthorId);
    //    }
    //    var discountList = discounts.ToList();
    //    var discountMax = discounts.Select(s => s.Percantage).Max();
        
       
    //}
}
