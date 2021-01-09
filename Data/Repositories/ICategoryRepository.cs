using Confectionery.DAL.Entities;
using System.Collections.Generic;

namespace Confectionery.DAL.Repositories
{
    public interface ICategoryRepository
    {
        public ICollection<Category> GetCategories();
        public void DeleteCategory(Category c);
    }
}
