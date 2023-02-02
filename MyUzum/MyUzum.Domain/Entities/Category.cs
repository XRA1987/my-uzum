namespace Uzum.Domain.Entities
{
    public class Category
    {

        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; }
    }
}
