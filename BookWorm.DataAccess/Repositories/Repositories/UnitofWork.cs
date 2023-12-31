﻿using BookWorm.DataAccess.Data;
using BookWorm.DataAccess.Repositories.IRepositories;

namespace BookWorm.DataAccess.Repositories.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository categoryRepository { get; private set; }
        public IProductRepository productRepository { get; private set; }
        public ICompanyRepository companyRepository { get; private set; }
        public IShoppingCartRepository shoppingCartRepository { get; private set; }
        public IApplicationUserRepository applicationUserRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            categoryRepository = new CategoryRepository(context);
            productRepository = new ProductRepository(context);
            companyRepository = new CompanyRepository(context);
            shoppingCartRepository = new ShoppingCartRepository(context);
            applicationUserRepository = new ApplicationUserRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
