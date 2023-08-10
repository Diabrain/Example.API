using Example.API.Entities;
using Example.API.Models;
using Example.API.Models.CreateModels;
using Example.API.Repositories;

namespace Example.API.Managers;

public class PublisherManager : IPublisherManager
{
    private readonly PublisherRepository _repository;
    public PublisherManager(PublisherRepository repository)
    {
        _repository = repository;
    }
    public async Task<PublisherModel> Create(CreatePublisherModel model)
    {
        var publisher = new Publisher()
        {
            Name = model.Name,
            Books = new List<Book>(),
            Discounts = new List<Discount>()
        };
        await _repository.Create(publisher);

        return publisher.ToModel();
    }
    public async Task<List<PublisherModel>> GetAll()
    {
        var list = await _repository.GetAll();
        return list.Select(x => x.ToModel()).ToList();
    }

    public async Task<PublisherModel> Get(int genreId)
    {
        var author = await _repository.GetById(genreId);
        return author.ToModel();
    }

}
