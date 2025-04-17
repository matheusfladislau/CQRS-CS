using CQRSCS.Application.Customers.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Customers.Handlers; 
public class CustomerRemoveCommandHandler : IRequestHandler<CustomerRemoveCommand, Customer> {
    private readonly ICustomerRepository _repository;
    public CustomerRemoveCommandHandler(ICustomerRepository repository) {
        this._repository = repository;
    }

    public async Task<Customer> Handle(CustomerRemoveCommand request, CancellationToken cancellationToken) {
        var customer = await _repository.GetByIdAsync(request.Id);
        if (customer == null) {
            throw new ApplicationException("Customer not found.");
        }

        return await _repository.RemoveAsync(customer);
    }
}
