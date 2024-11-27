using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(ApplicationDBContext context) : base(context)
        {

        }

        //Product sınıfına özel metodlar varsa burada tanımlanabilir.
        public void UpdateIsActive(Guid productID)
        {
            var product=GetByID(productID);

            if (product!=null)
            {
                product.IsActive = false;
                Update(product);
            }
        }
    }
}
