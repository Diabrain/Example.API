using Example.API.Models.CreateModels;
using Example.API.Models;

namespace Example.API.Managers;

public interface IDiscountManager
{
    Task<List<DiscountModel>> Getall();
    Task<DiscountModel> Get(int id);
    Task<DiscountModel> Create(CreateDiscountModel model);
}
