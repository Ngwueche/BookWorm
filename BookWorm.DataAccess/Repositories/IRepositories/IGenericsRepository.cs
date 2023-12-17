using System.Linq.Expressions;

namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IGenericsRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        //void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
