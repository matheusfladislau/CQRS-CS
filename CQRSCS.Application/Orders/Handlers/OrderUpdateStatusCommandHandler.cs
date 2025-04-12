using CQRSCS.Application.Orders.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Orders.Handlers; 
public sealed class OrderUpdateStatusCommandHandler : IRequestHandler<OrderUpdateStatusCommand, Order> {
    private readonly IOrderRepository _repository;
    public OrderUpdateStatusCommandHandler(IOrderRepository repository) {
        this._repository = repository;
    }

    public async Task<Order> Handle(OrderUpdateStatusCommand request, CancellationToken cancellationToken) {
        var orderToUpdate = await _repository.GetByIdAsync(request.Id);
        if (orderToUpdate == null) {
            throw new ApplicationException("Order not found.");
        }

        return await _repository.UpdateStatusAsync(orderToUpdate, request.Status);
    }
}

