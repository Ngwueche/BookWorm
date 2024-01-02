using BookWorm.Models.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IOrderHeaderRepository : IGenericsRepository<OrderHeader>
    {
        public void Update(OrderHeader orderHeader);
        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null);
        public void UpdateStripePaymentId(int id, string sessionId, string paymentIntentId);

    }
}
