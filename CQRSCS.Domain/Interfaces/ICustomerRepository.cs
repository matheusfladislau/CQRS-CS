using CQRSCS.Domain.Entities;

namespace CQRSCS.Domain.Interfaces; 
public interface ICustomerRepository {
    Task<IEnumerable<Customer>> GetCustomersAsync();
    Task<Customer> GetByIdAsync(int? id);

    Task<Customer> AddAsync(Customer customer);
    Task<Customer> RemoveAsync(Customer customer);
    Task<Customer> UpdateAsync(Customer customer);
}
