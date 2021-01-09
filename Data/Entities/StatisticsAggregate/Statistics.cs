namespace Confectionery.DAL.Entities
{
    public class Statistics
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Purchased { get; set; }
        public int PurchasedSeparately { get; set; }
    }
}
