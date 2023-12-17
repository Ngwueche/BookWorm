using BookWorm.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface ICategoryRepository : IGenericsRepository<Category>
    {
        void Update(Category category);
        void Save();
    }
}
