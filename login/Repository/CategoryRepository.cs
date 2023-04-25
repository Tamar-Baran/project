using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository: ICategoryRepository
    {
        CouchesShop213664998Context _DbContext;

        public CategoryRepository(CouchesShop213664998Context dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<Category> addCategoryAsync(Category category)
        {
            await _DbContext.Categories.AddAsync(category);
            await _DbContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> getAllCategoriesAsync()
        {
            return await _DbContext.Categories.ToListAsync();
        }

        //public async Task<IEnumerable<Category>> getCategory(Category category)
        //{
        //    return await _DbContext.Categories.ToListAsync();
        //}
    }
}
