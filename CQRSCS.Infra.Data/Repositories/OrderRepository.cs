using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Enums;
using CQRSCS.Domain.Interfaces;
using CQRSCS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSCS.Infra.Data.Repositories; 
public class OrderRepository : IOrderRepository {

    private readonly ApplicationDbContext _context;
    public OrderRepository(ApplicationDbContext context) {
        this._context = context;
    }

    public async Task<Order> AddAsync(Order order) {
        _context.Add(order);
        await _context.SaveChangesAsync();
        return order;
    }

    public async Task<Order> GetByIdAsync(int? id) {
        return await _context.Orders.FindAsync(id);
    }

    public async Task<IEnumerable<Order>> GetByStatusAsync(OrderStatus status) {
        return await _context.Orders
            .Where(x => x.Status == status)
            .ToListAsync();
    }

    public async Task<IEnumerable<Order>> GetOrdersAsync() {
        return await _context.Orders.ToListAsync();
    }

    public async Task<Order> RemoveAsync(Order order) {
        _context.Remove(order);
        await _context.SaveChangesAsync();
        return order;
    }

    public async Task<Order> UpdateAsync(Order order) {
        _context.Update(order);
        await _context.SaveChangesAsync();
        return order;
    }

    public async Task<Order> UpdateStatusAsync(Order order, OrderStatus status) {
        var orderToUpdate = await _context.Orders.FindAsync(order.Id);
        if (orderToUpdate != null) {
            orderToUpdate.UpdateStatus(status);
            await _context.SaveChangesAsync();
        }
        return orderToUpdate;
    }

}
