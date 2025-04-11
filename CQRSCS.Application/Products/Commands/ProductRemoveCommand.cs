using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Products.Commands; 
public sealed class ProductRemoveCommand : IRequest<Product> {
    public ProductRemoveCommand(int id) {
        this.Id = id;
    }

    public int Id { get; set; }
}
