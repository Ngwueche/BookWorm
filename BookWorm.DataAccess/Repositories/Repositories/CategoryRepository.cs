using BookWorm.DataAccess.Data;
using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;

namespace BookWorm.DataAccess.Repositories.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        //public void Add(Category entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Category Get(Expression<Func<Category, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Category> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(Category entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRange(IEnumerable<Category> entity)
        //{
        //    throw new NotImplementedException();
        //} 
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
