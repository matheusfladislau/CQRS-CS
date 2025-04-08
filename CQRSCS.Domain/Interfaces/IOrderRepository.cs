using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Enums;

namespace CQRSCS.Domain.Interfaces; 
public interface IOrderRepository {
    Task<IEnumerable<Order>> GetOrders();
    Task<Order> GetById(int? id);
    Task<Order> UpdateStatus(Order order, OrderStatus status);
    Task<IEnumerable<Order>> GetByStatus(OrderStatus status);

    Task<Order> Add(Order order);
    Task<Order> Remove(Order order);
    Task<Order> Update(Order order);
}
