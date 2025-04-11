using CQRSCS.Application.Products.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Products.Handlers; 
public sealed class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>> {
    private readonly IProductRepository _repository;
    public GetProductsQueryHandler(IProductRepository repository) {
        this._repository = repository;
    }

    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken) {
        return await _repository.GetProductsAsync();
    }
}
