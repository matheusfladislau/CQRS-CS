using CQRSCS.Application.Customers.Queries;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using MediatR;

namespace CQRSCS.Application.Customers.Handlers; 
public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, IEnumerable<Customer>> {
    private readonly ICustomerRepository _repository;
    public GetCustomersQueryHandler(ICustomerRepository repository) {
        this._repository = repository;
    }

    public async Task<IEnumerable<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken) {
        return await _repository.GetCustomersAsync();
    }
}
