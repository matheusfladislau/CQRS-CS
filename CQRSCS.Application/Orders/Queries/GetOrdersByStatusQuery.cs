using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Enums;
using MediatR;

namespace CQRSCS.Application.Orders.Queries; 
public class GetOrdersByStatusQuery : IRequest<IEnumerable<Order>> {
    public OrderStatus Status { get; set; }
    public GetOrdersByStatusQuery(OrderStatus status) {
        this.Status = status;
    }
}
