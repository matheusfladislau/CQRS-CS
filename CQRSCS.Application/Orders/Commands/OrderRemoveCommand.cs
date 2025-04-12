using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Orders.Commands; 
public class OrderRemoveCommand : IRequest<Order> {
    public int Id { get; set; }
    public OrderRemoveCommand(int id) {
        this.Id = id;
    }
}
