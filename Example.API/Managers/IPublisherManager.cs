using Example.API.Models.CreateModels;
using Example.API.Models;

namespace Example.API.Managers;

public interface IPublisherManager
{
    Task<List<PublisherModel>> GetAll();
    Task<PublisherModel> Get(int id);
    Task<PublisherModel> Create(CreatePublisherModel model);
}
