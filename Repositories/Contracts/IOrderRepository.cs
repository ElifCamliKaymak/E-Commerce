using Entities.Models;

namespace Repositories.Contracts
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        int NumberOfInProcess { get; }

        Order? GetOneOrder(int id);
        void Complete(int id);
        void SaveOrder(Order order);
    }
}