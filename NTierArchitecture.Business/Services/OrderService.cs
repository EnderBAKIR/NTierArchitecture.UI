using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace NTierArchitecture.Business.Services
{
    public class OrderService : IManager<Order>
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository oRepo)
        {
            _orderRepository = oRepo;
        }
        public void Create(Order entity)
        {
            OrderValidator oVal = new OrderValidator();
            ValidationResult result = oVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder stringBuilder = new StringBuilder();
                result.Errors.ForEach(s => stringBuilder.AppendLine(s.ErrorMessage));
                throw new Exception(stringBuilder.ToString());
            }

            _orderRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var ord = _orderRepository.GetByID(Id);
            if (ord != null) {
                _orderRepository.Delete(Id);
            }
        }

        public IEnumerable<Order> GetAll()
        {
           return _orderRepository.GetAll();
        }

        public Order GetByID(Guid Id)
        {
            if (Id==Guid.Empty)
            {
                throw new Exception("Id bulunamadı.");
            }

            return _orderRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Order, bool>> filter)
        {
            return _orderRepository.IfEntityExists(filter);
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
        }

        public Order GetOrderWithOrderDetails(Guid Id)
        {
          var order =  _orderRepository.GetOrderWithOrderDetails(Id);

            return order;
        }
    }
}
