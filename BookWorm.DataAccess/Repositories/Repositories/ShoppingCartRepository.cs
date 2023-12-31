using BookWorm.DataAccess.Data;
using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;

namespace BookWorm.DataAccess.Repositories.Repositories
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCartVM>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(ShoppingCartVM shoppingCart)
        {
            _context.ShoppingCarts.Update(shoppingCart);
        }
    }
}
