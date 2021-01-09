using Confectionery.DAL.Entities;
using System.Collections.Generic;

namespace Confectionery.DAL.Repositories
{
    public interface IProductsRepository
    {
        public ICollection<Product> GetProducts();
        public ICollection<Product> GetProducts(Category category);
        public Product GetProduct(int id);
        public void UpdateProduct(int id, KeyValuePair<string, object>[] properties);
        public void DeleteProduct(Product p);
    }
}
