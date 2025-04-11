using CQRSCS.Domain.Entities;

namespace CQRSCS.Domain.Interfaces; 
public interface IProductRepository {
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetByIdAsync(int? id);

    Task<Product> AddAsync(Product product);
    Task<Product> RemoveAsync(Product product);
    Task<Product> UpdateAsync(Product product);
}
