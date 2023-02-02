namespace Uzum.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }

        public decimal TotalSum { get; set; }

        public int ShopProductId { get; set; }

        public ShopProduct? ShopProduct { get; set; }
    }
}
