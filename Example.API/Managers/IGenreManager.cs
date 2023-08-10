using Example.API.Models.CreateModels;
using Example.API.Models;

namespace Example.API.Managers;

public interface IGenreManager
{
    Task<List<GenreModel>> GetAll();
    Task<GenreModel> Get(int id);
    Task<GenreModel> Create(CreateGenreModel model);
}
