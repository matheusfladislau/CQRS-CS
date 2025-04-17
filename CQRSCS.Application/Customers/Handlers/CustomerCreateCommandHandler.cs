using CQRSCS.Application.Customers.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Customers.Handlers; 
public class CustomerCreateCommandHandler : IRequestHandler<CustomerCreateCommand, Customer> {
    private readonly ICustomerRepository _repository;
    public CustomerCreateCommandHandler(ICustomerRepository repository) {
        this._repository = repository;
    }

    public async Task<Customer> Handle(CustomerCreateCommand request, CancellationToken cancellationToken) {
        var customer = new Customer(request.Name, request.Email, request.BirthDate);

        if (customer == null) {
            throw new ApplicationException("Error creating entity.");
        }

        return await _repository.AddAsync(customer);
    }
}
