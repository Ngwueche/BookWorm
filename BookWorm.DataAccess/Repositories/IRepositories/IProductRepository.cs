using BookWorm.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IProductRepository : IGenericsRepository<Product>
    {
        void Update(Product product);
    }
}
