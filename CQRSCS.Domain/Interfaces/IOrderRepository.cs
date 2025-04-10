using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Enums;

namespace CQRSCS.Domain.Interfaces; 
public interface IOrderRepository {
    Task<IEnumerable<Order>> GetOrdersAsync();
    Task<Order> GetByIdAsync(int? id);
    Task<Order> UpdateStatusAsync(Order order, OrderStatus status);
    Task<IEnumerable<Order>> GetByStatusAsync(OrderStatus status);

    Task<Order> AddAsync(Order order);
    Task<Order> RemoveAsync(Order order);
    Task<Order> UpdateAsync(Order order);
}
