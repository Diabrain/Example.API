using Example.API.Entities;
using Example.API.Models;
using Example.API.Models.CreateModels;
using Example.API.Repositories;

namespace Example.API.Managers;

public class BookManager : IBookManager
{
    private readonly BookRepository _bookRepository;
    public BookManager(BookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    public async Task<BookModel> Create(CreateBookModel model)
    {
        var book = new Book()
        {
            Name= model.Name,
            Price= model.Price,
            PublisherId= model.PublisherId,
            AuthorId= model.AuthorId,
            GenreId= model.GenreId,
        };
        await _bookRepository.Create(book);
        return book.ToModel();
    }

    public async Task<BookModel> Get(int id)
    {
        var book =  await _bookRepository.GetById(id);
        book = await _bookRepository.GetBook(book);
        return book.ToModel();
    }

    

    public async Task<List<BookModel>> Getall()
    {
        var list = await _bookRepository.GetAll();
        return list.Select(x => x.ToModel()).ToList();
    }
}
