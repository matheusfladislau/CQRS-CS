using CQRSCS.Domain.Entities;

namespace CQRSCS.Domain.Interfaces; 
public interface IProductRepository {
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> GetById(int? id);

    Task<Product> Add(Product product);
    Task<Product> Remove(Product product);
    Task<Product> Update(Product product);
}
