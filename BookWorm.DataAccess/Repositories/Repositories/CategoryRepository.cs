﻿using BookWorm.DataAccess.Data;
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
        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
