using BookWorm.DataAccess.Data;
using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models.Models;

namespace BookWorm.DataAccess.Repositories.Repositories
{
    public class OrderHeaderRepository : GenericRepository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderHeaderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(OrderHeader orderHeader)
        {
            _context.OrderHeaders.Update(orderHeader);
        }
    }
}
