using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace NTierArchitecture.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        private readonly CategoryRepository _repository;
        public CategoryService(CategoryRepository catRepo)
        {
            _repository = catRepo;
        }
        public void Create(Category entity)
        {
            if (IfEntityExists(c=>c.CategoryName==entity.CategoryName))
            {
                throw new Exception("Bu kategori daha önce kayıt edilmiştir.");
            }

            //Install-Package FluentValidation
            CategoryValidator cval = new();
            ValidationResult result = cval.Validate(entity);
            StringBuilder sb = new();
            result.Errors.ForEach(x => sb.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                //throw new Exception(string.Join(",", result.Errors));
                throw new Exception(sb.ToString());
            }

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cat = _repository.GetByID(Id);

            if (cat.IsActive)
            {
                throw new Exception("Aktif olan bir kategori silinemez.");
            }

            _repository.Delete(Id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Category, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Category entity)
        {
            if (entity != null)
            {
                _repository.Update(entity);
            }

        }
    }
}
