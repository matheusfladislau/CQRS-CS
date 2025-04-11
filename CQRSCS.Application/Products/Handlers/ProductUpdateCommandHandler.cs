using CQRSCS.Application.Products.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Products.Handlers; 
public sealed class ProductUpdateCommandHandler : IRequestHandler<ProductUpdateCommand, Product> {
    private readonly IProductRepository _repository;
    public ProductUpdateCommandHandler(IProductRepository repository) {
        this._repository = repository;
    }

    public async Task<Product> Handle(ProductUpdateCommand request, CancellationToken cancellationToken) {
        var product = await _repository.GetByIdAsync(request.Id);

        if (product == null) {
            throw new ApplicationException("Error creating Entity.");
        }
        product.Update(request.Name, request.Description,
            request.Price, request.Stock);
        return await _repository.UpdateAsync(product);
    }
}
