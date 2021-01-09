using System.Collections.Generic;
using System.Linq;

using Confectionery.DAL.Entities;

namespace Confectionery.DAL.Repositories
{
    public interface IOrderRepository
    {
        public ICollection<Order> GetOrders();
        public void RemoveOrder(Order order);
        public void AddOrder(Order order);
    }
}
