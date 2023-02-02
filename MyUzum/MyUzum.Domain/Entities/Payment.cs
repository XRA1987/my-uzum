namespace Uzum.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public int ContractId { get; set; }

        public DateTime Month { get; set; }

        public decimal TotalSum { get; set; }

        public bool IsPaid { get; set; }

        public Contract? Contract { get; set; }
    }
}
