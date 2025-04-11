using CQRSCS.Application.Products.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Products.Handlers;
public sealed class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product> {
    private readonly IProductRepository _repository;
    public GetProductByIdQueryHandler(IProductRepository repository) {
        this._repository = repository;
    }

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) {
        return await _repository.GetByIdAsync(request.Id);
    }
}
