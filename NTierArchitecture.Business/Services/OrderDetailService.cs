using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Services
{
    public class OrderDetailService : IManager<OrderDetail>
    {
        private readonly OrderDetailRepository _orderDetailRepository;
        public OrderDetailService(OrderDetailRepository odRepo)
        {
            _orderDetailRepository = odRepo;
        }
        public void Create(OrderDetail entity)
        {
            OrderDetailValidator odVal = new OrderDetailValidator();
            ValidationResult result = odVal.Validate(entity);

            if (!result.IsValid)
            {
                string hatalar = string.Join("-", result.Errors);
                throw new Exception(hatalar);
            }

            _orderDetailRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var od = _orderDetailRepository.GetByID(Id);

            if (od != null)
            {
                _orderDetailRepository.Delete(Id);
            }
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetByID(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new Exception("Id bulunamadı.");
            }

            return _orderDetailRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<OrderDetail, bool>> filter)
        {
            return _orderDetailRepository.IfEntityExists(filter);
        }

        public void Update(OrderDetail entity)
        {
            _orderDetailRepository.Update(entity);
        }
    }
}
