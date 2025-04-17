using CQRSCS.Application.Customers.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Customers.Handlers; 
public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer> {
    private readonly ICustomerRepository _repository;
    public GetCustomerByIdQueryHandler(ICustomerRepository repository) {
        this._repository = repository;
    }

    public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken) {
        return await _repository.GetByIdAsync(request.Id);
    }
}
