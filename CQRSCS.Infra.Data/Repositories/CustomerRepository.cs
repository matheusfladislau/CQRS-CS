using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using CQRSCS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSCS.Infra.Data.Repositories;
public class CustomerRepository : ICustomerRepository {
    private readonly ApplicationDbContext _context;
    public CustomerRepository(ApplicationDbContext context) {
        this._context = context;
    }

    public async Task<Customer> AddAsync(Customer customer) {
        _context.Add(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    public async Task<Customer> GetByIdAsync(int? id) {
        return await _context.Customers.FindAsync(id);
    }

    public async Task<IEnumerable<Customer>> GetCustomersAsync() {
        return await _context.Customers.ToListAsync();
    }

    public async Task<Customer> RemoveAsync(Customer customer) {
        _context.Remove(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    public async Task<Customer> UpdateAsync(Customer customer) {
        _context.Update(customer);
        await _context.SaveChangesAsync();
        return customer;
    }
}
