using CQRSCS.Application.Orders.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Orders.Handlers; 

public sealed class OrderUpdateCommandHandler : IRequestHandler<OrderUpdateCommand, Order> {
    private readonly IOrderRepository _repository;
    public OrderUpdateCommandHandler(IOrderRepository repository) {
        this._repository = repository;
    }

    public async Task<Order> Handle(OrderUpdateCommand request, CancellationToken cancellationToken) {
        var orderToUpdate = await _repository.GetByIdAsync(request.Id);
        if (orderToUpdate == null) {
            throw new ApplicationException("Order not found.");
        }

        orderToUpdate.Update(request.Date, request.Status);
        return await _repository.UpdateAsync(orderToUpdate);
    }
}
