using CQRSCS.Application.Orders.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Orders.Handlers; 
public sealed class GetOrdersByStatusQueryHandler : IRequestHandler<GetOrdersByStatusQuery, IEnumerable<Order>> {
    private readonly IOrderRepository _repository;
    public GetOrdersByStatusQueryHandler(IOrderRepository repository) {
        this._repository = repository;
    }

    public async Task<IEnumerable<Order>> Handle(GetOrdersByStatusQuery request, CancellationToken cancellationToken) {
        return await _repository.GetByStatusAsync(request.Status);
    }
}
