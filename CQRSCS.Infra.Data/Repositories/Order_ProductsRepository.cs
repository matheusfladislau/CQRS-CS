using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using CQRSCS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRSCS.Infra.Data.Repositories; 
public class Order_ProductsRepository : IOrder_ProductsRepository {
    private readonly ApplicationDbContext _context;
    public Order_ProductsRepository(ApplicationDbContext context) {
        this._context = context;
    }

    public async Task<Order_Product> AddAsync(Order_Product orderProduct) {
        _context.Add(orderProduct);
        await _context.SaveChangesAsync();
        return orderProduct;
    }

    public async Task<IEnumerable<Order_Product>> GetProductsByOrderIdAsync(int? orderId) {
        return await _context.Order_Products
            .Where(x => x.OrderId == orderId)
            .ToListAsync();
    }

    public async Task<Order_Product> RemoveAsync(Order_Product orderProduct) {
        _context.Remove(orderProduct);
        await _context.SaveChangesAsync();
        return orderProduct;
    }

    public async Task<Order_Product> UpdateQuantityAsync(Order_Product orderProduct) {
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
