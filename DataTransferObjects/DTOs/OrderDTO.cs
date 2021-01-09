using System;
using System.Collections.Generic;

namespace Confectionery.BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public IList<OrderItemDTO> OrderItems { get; set; }
        public DateTime Time { get; set; }
    }
}
