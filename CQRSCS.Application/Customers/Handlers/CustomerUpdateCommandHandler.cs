using CQRSCS.Application.Customers.Commands;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Customers.Handlers; 
public class CustomerUpdateCommandHandler : IRequestHandler<CustomerUpdateCommand, Customer> {
    private readonly ICustomerRepository _repository;
    public CustomerUpdateCommandHandler(ICustomerRepository repository) { 
        this._repository = repository;
    }

    public async Task<Customer> Handle(CustomerUpdateCommand request, CancellationToken cancellationToken) {
        var customer = await _repository.GetByIdAsync(request.Id);
        if (customer == null) {
            throw new ApplicationException("Customer not found.");
        }

        customer.Update(request.Name, request.Email, request.BirthDate);
        return await _repository.UpdateAsync(customer);
    }
}
