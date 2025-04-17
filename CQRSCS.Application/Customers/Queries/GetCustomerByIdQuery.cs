using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Customers.Queries; 
public class GetCustomerByIdQuery : IRequest<Customer> {
    public GetCustomerByIdQuery(int id) {
        this.Id = id;
    }
    public int Id { get; private set; }
}
