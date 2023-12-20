namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IUnitofWork
    {
        ICategoryRepository categoryRepository { get; }
        void Save();
    }
}
