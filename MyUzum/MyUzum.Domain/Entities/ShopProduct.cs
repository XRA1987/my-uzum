namespace Uzum.Domain.Entities
{
    public class ShopProduct
    {
        public ShopProduct()
        {
            BoughtProducts = new List<BoughtProduct>();
            Transactions = new List<Transaction>();
        }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }

        public Shop? Shop { get; set; }
        public Product? Product { get; set; }

        public ICollection<BoughtProduct> BoughtProducts { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
