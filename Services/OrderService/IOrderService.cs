using Confectionery.DAL.Entities;
using System.Collections.Generic;

namespace Confectionery.BLL.Services
{
    public interface IOrderService
    {
        ICollection<Order> GetOrders();
        bool AddOrder(Order order);
        void Execute(Order order);
    }
}
