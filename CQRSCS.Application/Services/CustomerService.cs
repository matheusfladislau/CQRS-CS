using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Application.Interfaces;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;

namespace CQRSCS.Application.Services;
public class CustomerService : ICustomerService {
    private readonly ICustomerRepository _repository;
    private readonly IMapper _mapper;
    public CustomerService(ICustomerRepository repository,
        IMapper mapper) {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task Add(CustomerDTO customer) {
        var customerEntity = _mapper.Map<Customer>(customer);
        await _repository.AddAsync(customerEntity);
    }

    public async Task<CustomerDTO> GetById(int? id) {
        var customersEntities = await _repository.GetByIdAsync(id);
        return _mapper.Map<CustomerDTO>(customersEntities);
    }

    public async Task<IEnumerable<CustomerDTO>> GetCustomers() {
        var customersEntities = await _repository.GetCustomersAsync();
        return _mapper.Map<IEnumerable<CustomerDTO>>(customersEntities);
    }

    public async Task Remove(CustomerDTO customer) {
        var customerEntity = _mapper.Map<Customer>(customer);
        await _repository.RemoveAsync(customerEntity);
    }

    public async Task Update(CustomerDTO customer) {
        var customerEntity = _mapper.Map<Customer>(customer);
        await _repository.UpdateAsync(customerEntity);
    }
}
