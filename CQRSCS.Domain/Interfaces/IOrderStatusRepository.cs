using CQRSCS.Domain.Enums;

namespace CQRSCS.Domain.Interfaces; 
public interface IOrderStatusRepository {
    Task<IEnumerable<OrderStatus>> GetOrderStatuses();
}
