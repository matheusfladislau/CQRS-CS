using CQRSCS.Application.Orders.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Orders.Handlers;
public sealed class OrderCreateCommandHandler : IRequestHandler<OrderCreateCommand, Order> {
    private readonly IOrderRepository _repository;
    public OrderCreateCommandHandler(IOrderRepository repository) {
        this._repository = repository;
    }

    public async Task<Order> Handle(OrderCreateCommand request, CancellationToken cancellationToken) {
        var order = new Order(request.Date, request.Status);

        if (order == null) {
            throw new ApplicationException("Error creating entity.");
        }
        return await _repository.AddAsync(order);
    }
}
