using CQRSCS.Application.Products.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Products.Handlers;
public sealed class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product> {
    private readonly IProductRepository _repository;
    public ProductRemoveCommandHandler(IProductRepository repository) {
        this._repository = repository;
    }

    public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken) {
        var product = await _repository.GetByIdAsync(request.Id);
        if (product == null) {
            throw new ApplicationException("Entity could not be found.");
        }
        return await _repository.RemoveAsync(product);
    }
}
