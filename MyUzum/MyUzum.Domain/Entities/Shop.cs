namespace Uzum.Domain.Entities
{
    public class Shop
    {
        public Shop()
        {
            ShopProducts = new List<ShopProduct>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal AccountNumber { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public ICollection<ShopProduct> ShopProducts { get; set; }

    }
}
