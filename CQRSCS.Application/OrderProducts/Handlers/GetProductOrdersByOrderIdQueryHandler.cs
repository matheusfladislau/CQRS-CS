using CQRSCS.Application.OrderProducts.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.OrderProducts.Handlers; 
public sealed class GetProductOrdersByOrderIdQueryHandler : IRequestHandler<GetProductOrdersByOrderIdQuery, IEnumerable<OrderProduct>> {
    private readonly IOrderProductsRepository _repository;
    public GetProductOrdersByOrderIdQueryHandler(IOrderProductsRepository repository) {
        this._repository = repository;
    }

    public async Task<IEnumerable<OrderProduct>> Handle(GetProductOrdersByOrderIdQuery request, CancellationToken cancellationToken) {
        return await _repository.GetProductsByOrderIdAsync(request.OrderId);
    }
}
