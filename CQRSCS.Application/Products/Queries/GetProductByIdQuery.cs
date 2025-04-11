using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Products.Queries; 
public sealed class GetProductByIdQuery : IRequest<Product> {
    public GetProductByIdQuery(int id) {
        this.Id = id;
    }
    public int Id { get; set; }
}
