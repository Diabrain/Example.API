using Example.API.Entities;
using Example.API.Models;
using Example.API.Models.CreateModels;
using Example.API.Models.UpdateModels;
using Example.API.Repositories;

namespace Example.API.Managers;

public class GenreManager : IGenreManager
{
    private readonly GenreRepository _repository;
    public GenreManager(GenreRepository repository)
    {
        _repository = repository;
    }
    public async Task<GenreModel> Create(CreateGenreModel model)
    {
        var genre = new Genre()
        {
            Name = model.Name,
            Books = new List<Book>()
        };
        await _repository.Create(genre);

        return genre.ToModel();
    }
    public async Task<List<GenreModel>> GetAll()
    {
        var list = await _repository.GetAll();
        return list.Select(x => x.ToModel()).ToList();
    }

    public async Task<GenreModel> Get(int id)
    {
        var author = await _repository.GetById(id);
        return author.ToModel();
    }

   
}
