using BookWorm.DataAccess.Data;
using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;

namespace BookWorm.DataAccess.Repositories.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
