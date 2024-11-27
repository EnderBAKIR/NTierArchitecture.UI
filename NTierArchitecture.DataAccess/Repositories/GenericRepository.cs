using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        protected readonly ApplicationDBContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDBContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _dbSet.Remove(GetByID(Id));
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(Guid Id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == Id) ?? throw new Exception("Bulunamadı");

            //if (data == null)
            //{
            //    throw new Exception("Bulunamadı.");
            //}
            //return data;

            //! bir ifadenin kesinlikle null gelmeyeceğini bildirmek için kullanılır.
            //return (_dbSet.FirstOrDefault(x => x.Id == Id))!;
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            _dbContext.SaveChanges();
        }
    }
}
