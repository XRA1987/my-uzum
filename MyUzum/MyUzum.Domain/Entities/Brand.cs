namespace Uzum.Domain.Entities
{
    public class Brand
    {
        public Brand()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Product> Products { get; set; }

    }
}
