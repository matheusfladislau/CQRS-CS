using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Customers.Commands; 
public sealed class CustomerRemoveCommand : IRequest<Customer> {
    public CustomerRemoveCommand(int id) {
        this.Id = id;
    }
    public int Id { get; private set; }
}
