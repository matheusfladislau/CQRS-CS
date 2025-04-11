using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using CQRSCS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSCS.Infra.Data.Repositories; 
public class OrderProductsRepository : IOrderProductsRepository {
    private readonly ApplicationDbContext _context;
    public OrderProductsRepository(ApplicationDbContext context) {
        this._context = context;
    }

    public async Task<OrderProduct> AddAsync(OrderProduct orderProduct) {
        _context.Add(orderProduct);
        await _context.SaveChangesAsync();
        return orderProduct;
    }

    public async Task<IEnumerable<OrderProduct>> GetProductsByOrderIdAsync(int? orderId) {
        return await _context.Order_Products
            .Where(x => x.OrderId == orderId)
            .ToListAsync();
    }

    public async Task<OrderProduct> RemoveAsync(OrderProduct orderProduct) {
        _context.Remove(orderProduct);
        await _context.SaveChangesAsync();
        return orderProduct;
    }

    public async Task<OrderProduct> UpdateQuantityAsync(OrderProduct orderProduct) {
        var order = await _context.Order_Products
                    .Where(x => x.ProductId == orderProduct.ProductId
                             && x.OrderId == orderProduct.OrderId)
                    .FirstOrDefaultAsync();

        if (order != null) {
            order.Update(orderProduct.Quantity);
            await _context.SaveChangesAsync();
        }
        return order;
    }
}
