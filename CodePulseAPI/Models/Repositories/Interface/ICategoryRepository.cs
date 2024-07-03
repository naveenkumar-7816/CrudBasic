using CodePulseAPI.Data;
using CodePulseAPI.Models.Domain;

namespace CodePulseAPI.Models.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
    
}
