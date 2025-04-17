using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Customers.Commands; 
public class CustomerCommand : IRequest<Customer> {
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime? BirthDate { get; set; }
}
