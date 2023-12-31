using BookWorm.DataAccess.Data;
using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models.Models;

namespace BookWorm.DataAccess.Repositories.Repositories
{
    public class CompanyRepository : GenericRepository<CompanyUser>, ICompanyRepository
    {
        private readonly ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(CompanyUser company)
        {
            _context.Companies.Update(company);
        }
    }
}

