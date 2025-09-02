using GAF.API.Models;

namespace GAF.API.Repositories.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllByUserIdAsync(string userId);
    Task<Category> GetIdAsync(int id, string userId);
    Task<Category> GetByNameAsync(string name, string userId);
    Task<Category> CreateAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<Category> DeleteAsync(int id, string userId);
    Task<bool> HasTranactionAsync(int id, string userId);

}
