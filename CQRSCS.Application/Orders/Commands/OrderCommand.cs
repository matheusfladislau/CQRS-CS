using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Enums;
using MediatR;

namespace CQRSCS.Application.Orders.Commands;     
public class OrderCommand : IRequest<Order> {
    public DateTime? Date { get; set; }
    public OrderStatus Status { get; set; }
    public int CustomerId { get; set; }
}
