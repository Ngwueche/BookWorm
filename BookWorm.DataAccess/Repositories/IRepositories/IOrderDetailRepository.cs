using BookWorm.Models.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IOrderDetailRepository : IGenericsRepository<OrderDetail>
    {
        public void Update(OrderDetail orderDetail);
    }
}
