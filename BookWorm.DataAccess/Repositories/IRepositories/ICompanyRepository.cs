using BookWorm.Models.Models;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface ICompanyRepository : IGenericsRepository<CompanyUser>
    {
        void Update(CompanyUser company);
    }
}
