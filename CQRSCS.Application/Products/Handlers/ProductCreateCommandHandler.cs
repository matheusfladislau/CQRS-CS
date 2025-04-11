using AutoMapper;
using CQRSCS.Application.Products.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Products.Handlers;
public sealed class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Product> {
    private readonly IProductRepository _repository;
    public ProductCreateCommandHandler(IProductRepository repository) {
        this._repository = repository;
    }

    public async Task<Product> Handle(ProductCreateCommand request, CancellationToken cancellationToken) {
        var product = new Product(request.Name, request.Description, 
            request.Price, request.Stock);

        if (product == null) {
            throw new ApplicationException("Error creating entity.");
        }
        return await _repository.AddAsync(product);
    }
}
