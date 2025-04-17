using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Customers.Queries; 
public class GetCustomersQuery : IRequest<IEnumerable<Customer> {
}
