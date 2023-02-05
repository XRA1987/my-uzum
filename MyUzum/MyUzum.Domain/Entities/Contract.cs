namespace Uzum.Domain.Entities
{
    public class Contract
    {
        public Contract()
        {
            BoughtProducts = new List<BoughtProduct>();
            Payments = new List<Payment>();

        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public User? User { get; set; }

        public ICollection<BoughtProduct> BoughtProducts { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
