using CQRSCS.Application.OrderProducts.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Handlers; 
public sealed class OrderProductRemoveCommandHandler : IRequestHandler<OrderProductRemoveCommand, OrderProduct> {
    private readonly IOrderProductsRepository _repository;
    public OrderProductRemoveCommandHandler(IOrderProductsRepository repository) {
        this._repository = repository;
    }

    public async Task<OrderProduct> Handle(OrderProductRemoveCommand request, CancellationToken cancellationToken) {
        var orderProduct = await _repository
            .GetProductOrderByIdsAsync(request.ProductId, request.OrderId);
        if (orderProduct == null) {
            throw new ApplicationException("Product from order not found.");
        }

        return await _repository.RemoveAsync(orderProduct);
    }
}
