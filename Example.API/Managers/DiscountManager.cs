using Example.API.Entities;
using Example.API.Models;
using Example.API.Models.CreateModels;
using Example.API.Repositories;

namespace Example.API.Managers;

public class DiscountManager : IDiscountManager
{
    private readonly DiscountRepository _repository;
    public DiscountManager(DiscountRepository repository)
    {
        _repository = repository;
    }

    public async Task<DiscountModel> Create(CreateDiscountModel model)
    {
        var discount = new Discount()
        {
            PublisherId = model.PublisherId,
            AuthorId = model.AuthorId,
            BookId = model.BookId,
            Percantage = model.Percantage,
        };
        await _repository.Create(discount);
        return discount.ToModel();
    }

    public async Task<DiscountModel> Get(int id)
    {
        var discount = await _repository.GetById(id);
        return discount.ToModel();
    }

    public async Task<List<DiscountModel>> Getall()
    {
        var list = await _repository.GetAll();
        return list.Select(x => x.ToModel()).ToList();
    }
}
