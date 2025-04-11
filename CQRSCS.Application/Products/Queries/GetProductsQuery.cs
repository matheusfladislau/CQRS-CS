using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Products.Queries; 
public sealed class GetProductsQuery : IRequest<IEnumerable<Product>> {
}
