using CQRSCS.Application.DTOs;

namespace CQRSCS.Application.Interfaces; 
public interface IProductService {
    Task<IEnumerable<ProductDTO>> GetProducts();
    Task<ProductDTO> GetById(int? id);

    Task Add(ProductDTO productDTO);
    Task Remove(ProductDTO productDTO);
    Task Update(ProductDTO productDTO);
}
