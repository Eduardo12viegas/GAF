using GAF.API.Models;
using GAF.API.Repositories.Interfaces;

namespace GAF.API.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public Task<Category> CreateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Category>> GetAllByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByNameAsync(string name, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetIdAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }
    public Task<Category> UpdateAsync(Category category)
    {
        throw new NotImplementedException();
    }

      public Task<Category> DeleteAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasTranactionAsync(int id, string userId)
    {
        throw new NotImplementedException();
        
    }

}