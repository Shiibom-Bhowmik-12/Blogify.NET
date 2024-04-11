using Blogify.API.Models.Domain;

namespace Blogify.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
