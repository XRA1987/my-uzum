namespace Uzum.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            ShopProducts= new List<ShopProduct>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Amount { get; set; }
        public int CategoryId { get; set; }

        public int BrandId { get; set; }

        public Category? Category { get; set; }

        public Brand? Brand { get; set; }

        public ICollection<ShopProduct> ShopProducts { get; set; }

    }
}
