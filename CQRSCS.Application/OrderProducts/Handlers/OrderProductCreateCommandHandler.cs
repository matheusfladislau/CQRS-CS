using CQRSCS.Application.OrderProducts.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Handlers; 
public sealed class OrderProductCreateCommandHandler : IRequestHandler<OrderProductCreateCommand, OrderProduct> {
    private readonly IOrderProductsRepository _repository;
    public OrderProductCreateCommandHandler(IOrderProductsRepository repository) {
        this._repository = repository;
    }

    public async Task<OrderProduct> Handle(OrderProductCreateCommand request, CancellationToken cancellationToken) {
        var orderProduct = new OrderProduct(request.Quantity, request.ProductId, request.OrderId);
        if (orderProduct == null) {
            throw new ApplicationException("Error creating entity.");
        }

        return await _repository.AddAsync(orderProduct);
    }
}
