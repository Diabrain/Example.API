using Example.API.Context;
using Example.API.Entities;
using Example.API.Models;
using Example.API.Models.CreateModels;
using Example.API.Models.UpdateModels;
using Example.API.Repositories;

namespace Example.API.Managers;

public class AuthorManager : IAuthorManager
{
    private readonly AuthorRepository _authorRepository;
    public AuthorManager(AuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    public async Task<AuthorModel> CreateAsync(CreateAuthorModel model)
    {
        var author = new Author()
        { 
            Name= model.Name,
            Books = new List<Book>(),
            Discounts = new List<Discount>()
        };
        await _authorRepository.Create(author);

        return author.ToModel();
    }

    public async Task DeleteAsync(int authorId)
    {
        var author = await _authorRepository.GetById(authorId);
        await _authorRepository.Delete(author);
    }

    public async Task<List<AuthorModel>> GetAllAsync()
    {
        var list = await _authorRepository.GetAll();
        return list.Select(x => x.ToModel()).ToList(); 
    }

    public async Task<AuthorModel> GetByIdAsync(int authorId)
    {
        var author  = await _authorRepository.GetById(authorId);
        return author.ToModel();
    }

    public async Task<AuthorModel> UpdateAsync(int authorId, UpdateAuthorModel model)
    {

        var author = await _authorRepository.GetById(authorId);
        await _authorRepository.Update(author);
        return author.ToModel();
    }
}
