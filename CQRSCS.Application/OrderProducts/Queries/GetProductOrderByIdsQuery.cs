using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Queries; 
public sealed class GetProductOrderByIdsQuery : IRequest<OrderProduct> {
    public GetProductOrderByIdsQuery(int productId, int orderId) {
        this.ProductId = productId;
        this.OrderId = orderId;
    }
    public int ProductId { get; private set; }
    public int OrderId { get; private set; }
}
