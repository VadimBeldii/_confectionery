using AutoMapper;
using System.Collections.Generic;

using Confectionery.BLL.DTOs;
using Confectionery.DAL.Entities;

namespace Confectionery.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly DAL.IUnitOfWork unitOfWork;
        public OrderService(DAL.IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
        }

        private void SaveStatistics(Order order)
        {
            foreach (var item in order.OrderItems)
            {
                if (order.OrderItems.Count > 1)
                {
                    unitOfWork.Statistics.Add(new Statistics { ProductId = item.ProductId, Purchased = item.Count });
                }
                else
                {
                    unitOfWork.Statistics.Add(new Statistics { ProductId = item.ProductId, PurchasedSeparately = item.Count });
                }
            }
        }
        public bool AddOrder(Order order)
        {
            //проверка на корректность
            foreach (var item in order.OrderItems)
            {
                var product = unitOfWork.Products.GetProduct(item.ProductId);
                if (product == null || item.Count > product.Count)
                {
                    return false;
                }
            }
            SaveStatistics(order);
            //уменьшаем количество
            foreach (var item in order.OrderItems)
            {
                var product = unitOfWork.Products.GetProduct(item.ProductId);
                unitOfWork.Products.UpdateProduct(item.ProductId, new[] { KeyValuePair.Create<string, object>("Count", product.Count - item.Count) });
            }
            unitOfWork.Orders.AddOrder(order);
            unitOfWork.Save();
            return true;
        }

        public void Execute(Order order)
        {
            unitOfWork.Orders.RemoveOrder(order);
            unitOfWork.Save();
        }

        public ICollection<Order> GetOrders()
        {
            var result = unitOfWork.Orders.GetOrders();
            return result;
        }
    }
}
