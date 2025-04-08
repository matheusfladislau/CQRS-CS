using CQRSCS.Domain.Entities;

namespace CQRSCS.Domain.Interfaces; 
public interface ICustomerRepository {
    Task<IEnumerable<Customer>> GetCustomers();
    Task<Customer> GetById(int? id);

    Task<Customer> Add(Customer customer);
    Task<Customer> Remove(Customer customer);
    Task<Customer> Update(Customer customer);
}
