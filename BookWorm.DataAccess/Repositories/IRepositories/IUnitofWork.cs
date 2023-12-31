namespace BookWorm.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        ICategoryRepository categoryRepository { get; }
        IProductRepository productRepository { get; }
        ICompanyRepository companyRepository { get; }
        IShoppingCartRepository shoppingCartRepository { get; }
        IApplicationUserRepository applicationUserRepository { get; }
        void Save();
    }
}
