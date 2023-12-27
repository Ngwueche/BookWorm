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
            var existingProduct = _context.Products.FirstOrDefault(u => u.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Title = product.Title;
                existingProduct.Description = product.Description;
                existingProduct.ISBN = product.ISBN;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.Price = product.Price;
                existingProduct.Price50 = product.Price50;
                existingProduct.Price100 = product.Price100;
                existingProduct.ListPrice = product.ListPrice;
                if (existingProduct.ImageUrl != null)
                {
                    existingProduct.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
