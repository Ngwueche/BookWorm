using BookWorm.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IShoppingCartRepository : IGenericsRepository<ShoppingCartVM>
    {
        void Update(ShoppingCartVM shoppingCart);
    }
}
