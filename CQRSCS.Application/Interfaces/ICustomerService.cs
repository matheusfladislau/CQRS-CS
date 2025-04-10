using CQRSCS.Application.DTOs;

namespace CQRSCS.Application.Interfaces; 
public interface ICustomerService {
    Task<IEnumerable<CustomerDTO>> GetCustomers();
    Task<CustomerDTO> GetById(int? id);

    Task Add(CustomerDTO customer);
    Task Remove(CustomerDTO customer);
    Task Update(CustomerDTO customer);
}
