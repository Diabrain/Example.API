using Example.API.Models;
using Example.API.Models.CreateModels;

namespace Example.API.Managers;

public interface IBookManager
{
    Task<List<BookModel>> Getall();
    Task<BookModel> Get(int id);
    Task<BookModel> Create(CreateBookModel model);
}
