using BookWorm.DataAccess.Data;
using BookWorm.DataAccess.Repositories.IRepositories;

namespace BookWorm.DataAccess.Repositories.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository categoryRepository { get; private set; }

        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;
            categoryRepository = new CategoryRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
