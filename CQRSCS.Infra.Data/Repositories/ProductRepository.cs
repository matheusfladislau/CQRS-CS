using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;
using CQRSCS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace CQRSCS.Infra.Data.Repositories; 
public class ProductRepository : IProductRepository {
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context) {
        this._context = context;
    }

    public async Task<Product> AddAsync(Product product) {
        _context.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product> GetByIdAsync(int? id) {
        return await _context.Products.FindAsync(id);
    }

    public async Task<IEnumerable<Product>> GetProductsAsync() {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> RemoveAsync(Product product) {
        _context.Remove(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product> UpdateAsync(Product product) {
        _context.Update(product);
        await _context.SaveChangesAsync();
        return product;
    }
}
