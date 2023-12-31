using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class OrderManager : IOrderService
    {
        private readonly IRepositoryManager _manager;

        public OrderManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IQueryable<Order> Orders => _manager.OrderRepository.Orders;

        public int NumberOfInProcess => _manager.OrderRepository.NumberOfInProcess;

        public void Complete(int id)
        {
            _manager.OrderRepository.Complete(id);
            _manager.Save();
        }

        public Order? GetOneOrder(int id)
        {
            return _manager.OrderRepository.GetOneOrder(id);
        }

        public void SaveOrder(Order order)
        {
            _manager.OrderRepository.SaveOrder(order);
        }
    }
}