using CQRSCS.Domain.Entities;

namespace CQRSCS.Domain.Interfaces; 
public interface IOrderProductsRepository {
    Task<IEnumerable<OrderProduct>> GetProductsByOrderIdAsync(int? orderId);

    Task<OrderProduct> AddAsync(OrderProduct orderProduct);
    Task<OrderProduct> UpdateQuantityAsync(OrderProduct orderProduct);
    Task<OrderProduct> RemoveAsync(OrderProduct orderProduct);
}
