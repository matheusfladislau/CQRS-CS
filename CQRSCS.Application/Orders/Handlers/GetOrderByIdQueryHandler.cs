using CQRSCS.Application.Orders.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Orders.Handlers; 
public sealed class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Order> {
    private readonly IOrderRepository _repository;
    public GetOrderByIdQueryHandler(IOrderRepository repository) {
        this._repository = repository;
    }

    public async Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken) {
        return await _repository.GetByIdAsync(request.Id);
    }
}
