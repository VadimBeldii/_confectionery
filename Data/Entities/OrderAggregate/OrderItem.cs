﻿namespace Confectionery.DAL.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int count { get; set; }
    }
}
