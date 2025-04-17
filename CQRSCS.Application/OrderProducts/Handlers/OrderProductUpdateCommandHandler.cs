using CQRSCS.Application.OrderProducts.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Handlers;
public sealed class OrderProductUpdateCommandHandler : IRequestHandler<OrderProductUpdateCommand, OrderProduct> {
    private readonly IOrderProductsRepository _repository;
    public OrderProductUpdateCommandHandler(IOrderProductsRepository repository) {
        this._repository = repository;
    }

    public async Task<OrderProduct> Handle(OrderProductUpdateCommand request, CancellationToken cancellationToken) {
        var orderProduct = await _repository.GetProductOrderByIdsAsync(request.ProductId, request.OrderId);
        if (orderProduct == null) {
            throw new ApplicationException("Product of order not found.");
        }

        orderProduct.Update(request.Quantity);
        return await _repository.UpdateQuantityAsync(orderProduct);
    }
}

