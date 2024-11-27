using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class CardItem
    {
        public Guid CardItemID { get; set; } = Guid.NewGuid();
        public Guid ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
