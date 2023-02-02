using Uzum.Domain.Enums;

namespace Uzum.Domain.Entities
{
    public class BoughtProduct
    {
        public int Id { get; set; }
        public int ShopProductId { get; set; }
        public int ContractId { get; set; }
        public ContractStatus ContractPeriod { get; set; }
        public ShopProduct? ShopProduct { get; set; }
        public Contract? Contract { get; set; }
    }
}
