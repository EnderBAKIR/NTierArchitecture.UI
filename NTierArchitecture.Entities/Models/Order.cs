using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public class Order : Entity
    {
        public DateOnly OrderDate { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipCountry { get; set; }
        public Employee? Employee { get; set; }
        public Guid EmployeeID { get; set; }
        public Customer? Customer { get; set; }
        public Guid CustomerID { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
