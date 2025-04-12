using CQRSCS.Application.Orders.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Orders.Handlers; 
public sealed class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IEnumerable<Order>> {
    private readonly IOrderRepository _repository;
    public GetOrdersQueryHandler(IOrderRepository repository) {
        this._repository = repository;
    }

    public async Task<IEnumerable<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken) {
        return await _repository.GetOrdersAsync();
    }
}
