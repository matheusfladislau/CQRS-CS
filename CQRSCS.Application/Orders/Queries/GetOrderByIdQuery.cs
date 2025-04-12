using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Orders.Queries; 
public class GetOrderByIdQuery : IRequest<Order> {
    public int Id { get; set; }
    public GetOrderByIdQuery(int id) {
        this.Id = id;
    }
}
