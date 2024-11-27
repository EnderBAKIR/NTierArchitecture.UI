using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository(ApplicationDBContext context) : base(context)
        {

        }

        public Order GetOrderWithOrderDetails(Guid Id)
        {
            var order = _dbContext.Orders
                .Include(x => x.Customer)
                .Include(x => x.Customer)
             .Include(x => x.OrderDetails)
             .ThenInclude(x => x.Product)
             .FirstOrDefault(x => x.Id == Id);

            return order;
        }

    }
}
