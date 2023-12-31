using BookWorm.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IApplicationUserRepository : IGenericsRepository<ApplicationUser>
    {
        void Update(ApplicationUser application);

    }
}
