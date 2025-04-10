using CQRSCS.Domain.Entities;

namespace CQRSCS.Domain.Interfaces; 
public interface IOrder_ProductsRepository {
    Task<IEnumerable<Order_Product>> GetProductsByOrderIdAsync(int? orderId);

    Task<Order_Product> AddAsync(Order_Product orderProduct);
    Task<Order_Product> UpdateQuantityAsync(Order_Product orderProduct);
    Task<Order_Product> RemoveAsync(Order_Product orderProduct);
}
