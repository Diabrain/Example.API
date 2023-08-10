using Example.API.Models;
using Example.API.Models.CreateModels;
using Example.API.Models.UpdateModels;

namespace Example.API.Managers;

public interface IAuthorManager
{
    Task<List<AuthorModel>> GetAllAsync();
    Task<AuthorModel> GetByIdAsync(int authorId);
    Task<AuthorModel> CreateAsync(CreateAuthorModel model);
    Task<AuthorModel> UpdateAsync(int authorId,UpdateAuthorModel model);
    Task DeleteAsync(int authorId);  
}
