using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace NTierArchitecture.Business.Services
{
    public class ProductService : IManager<Product>
    {
        private readonly ProductRepository _productRepository;
        public ProductService(ProductRepository pRepo)
        {
            _productRepository = pRepo;
        }
        public void Create(Product entity)
        {
            ProductValidator pVal = new ProductValidator();
            ValidationResult result = pVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }

            _productRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var prd = _productRepository.GetByID(Id);

            if (prd != null)
            {
                _productRepository.Delete(Id);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetByID(Guid Id)
        {
            return _productRepository.GetByID(Id);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void ChangeProductStatus(Guid pID)
        {
            _productRepository.UpdateIsActive(pID);
        }

        public bool IfEntityExists(Expression<Func<Product, bool>> filter)
        {
            return _productRepository.IfEntityExists(filter);
        }
    }
}
