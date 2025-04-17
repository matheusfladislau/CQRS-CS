using CQRSCS.Application.OrderProducts.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Handlers; 
public sealed class GetProductOrderByIdsQueryHandler : IRequestHandler<GetProductOrderByIdsQuery, OrderProduct> {
    private readonly IOrderProductsRepository _repository;
    public GetProductOrderByIdsQueryHandler(IOrderProductsRepository repository) {
        this._repository = repository; 
    }

    public async Task<OrderProduct> Handle(GetProductOrderByIdsQuery request, CancellationToken cancellationToken) {
        return await _repository.GetProductOrderByIdsAsync(request.ProductId, request.OrderId);
    }
}
