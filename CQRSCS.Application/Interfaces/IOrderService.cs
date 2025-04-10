using CQRSCS.Application.DTOs;
using CQRSCS.Domain.Enums;

namespace CQRSCS.Application.Interfaces; 
public interface IOrderService {
    Task<IEnumerable<OrderDTO>> GetOrders();
    Task<OrderDTO> GetById(int? id);
    Task<OrderDTO> UpdateStatus(OrderDTO order, OrderStatus status);
    Task<IEnumerable<OrderDTO>> GetByStatus(OrderStatus status);

    Task<OrderDTO> Add(OrderDTO order);
    Task<OrderDTO> Remove(OrderDTO order);
    Task<OrderDTO> Update(OrderDTO order);
}
