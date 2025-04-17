using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Commands; 
public class OrderProductCommand : IRequest<OrderProduct> {
    public int ProductId { get; set; }
    public int OrderId { get; set; }
}
