using CQRSCS.Application.DTOs;
using CQRSCS.Domain.Enums;

namespace CQRSCS.Application.Interfaces; 
public interface IOrderService {
    Task<IEnumerable<OrderDTO>> GetOrders();
    Task<OrderDTO> GetById(int? id);
    Task UpdateStatus(OrderDTO order, OrderStatus status);
    Task<IEnumerable<OrderDTO>> GetByStatus(OrderStatus status);

    Task Add(OrderDTO order);
    Task Remove(OrderDTO order);
    Task Update(OrderDTO order);
}
