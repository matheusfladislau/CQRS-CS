using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Orders.Queries; 
public class GetOrdersQuery : IRequest<IEnumerable<Order>> {
}
