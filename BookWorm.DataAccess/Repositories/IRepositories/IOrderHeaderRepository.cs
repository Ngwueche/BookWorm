using BookWorm.Models.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IOrderHeaderRepository : IGenericsRepository<OrderHeader>
    {
        public void Update(OrderHeader orderHeader);
    }
}
