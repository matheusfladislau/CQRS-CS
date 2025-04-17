using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Queries; 
public sealed class GetProductOrdersByOrderIdQuery : IRequest<IEnumerable<OrderProduct>> {
    public GetProductOrdersByOrderIdQuery(int orderId) {
        this.OrderId = orderId;
    }
    public int OrderId { get; private set; }
}
