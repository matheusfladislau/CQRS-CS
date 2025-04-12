using CQRSCS.Application.Orders.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Orders.Handlers; 
public sealed class OrderRemoveCommandHandler : IRequestHandler<OrderRemoveCommand, Order> {
    private readonly IOrderRepository _repository;
    public OrderRemoveCommandHandler(IOrderRepository repository) {
        this._repository = repository;
    }

    public async Task<Order> Handle(OrderRemoveCommand request, CancellationToken cancellationToken) {
        var order = await _repository.GetByIdAsync(request.Id);
        if (order == null) {
            throw new ApplicationException("Order not found.");
        }

        return await _repository.RemoveAsync(order);
    }
}
