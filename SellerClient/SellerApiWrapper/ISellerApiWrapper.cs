using Confectionery.BLL.DTOs;
using Confectionery.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SellerClient
{
    public interface IApiWrapper
    {
        public ICollection<CategoryDTO> GetCategories();
        public ICollection<ProductDTO> GetProducts();
        public ICollection<Order> GetOrders();
        public void SendOrder(Order order);
        public void MarkOrderAsExecuted(Order order);
    }
}
