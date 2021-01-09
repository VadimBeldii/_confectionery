using Confectionery.BLL.DTOs;
using Confectionery.DAL.Entities;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace SellerClient
{
    public class ApiWrapper : IApiWrapper
    {
        private readonly IApiClient apiClient = new ApiClient();
        public ICollection<CategoryDTO> GetCategories()
        {
            var result = apiClient.ProcessHttpGetRequest("getcategories");
            return JsonSerializer.Deserialize<ICollection<CategoryDTO>>(result);
        }
        public ICollection<ProductDTO> GetProducts()
        {
            var result = apiClient.ProcessHttpGetRequest("getproducts");
            return JsonSerializer.Deserialize<ICollection<ProductDTO>>(result);
        }
        public ICollection<Order> GetOrders()
        {
            var result = apiClient.ProcessHttpGetRequest("getorders");
            return JsonSerializer.Deserialize<ICollection<Order>>(result);
        }
        public void SendOrder(Order order)
        {
            apiClient.ProcessHttpPostRequest("addorder", JsonSerializer.Serialize(order));
        }
        public void MarkOrderAsExecuted(Order order)
        {
            apiClient.ProcessHttpPostRequest("executeorder", JsonSerializer.Serialize(order));
        }
    }
}
