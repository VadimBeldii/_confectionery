using Confectionery.DAL.EF;
using System.Collections.Generic;
using System.Linq;

using Confectionery.DAL.Entities;

namespace Confectionery.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly ConfectioneryDbContext context;
        public CategoryRepository(ConfectioneryDbContext context) => this.context = context;

        public ICollection<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
        public void DeleteCategory(Category c)
        {
            context.Categories.Remove(c);
        }
    }
}
