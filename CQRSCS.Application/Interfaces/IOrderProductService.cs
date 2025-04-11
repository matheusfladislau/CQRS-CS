using CQRSCS.Application.DTOs;

namespace CQRSCS.Application.Interfaces; 
public interface IOrderProductService {
    Task<IEnumerable<OrderProductDTO>> GetProductsByOrderId(int? orderId);

    Task Add(OrderProductDTO orderProduct);
    Task UpdateQuantity(OrderProductDTO orderProduct);
    Task Remove(OrderProductDTO orderProduct);
}
