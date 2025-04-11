using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Application.Interfaces;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;

namespace CQRSCS.Application.Services;
public class ProductService : IProductService {
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository repository,
        IMapper mapper) {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task Add(ProductDTO productDTO) {
        var productEntity = _mapper.Map<Product>(productDTO);
        await _repository.AddAsync(productEntity);
    }

    public async Task<ProductDTO> GetById(int? id) {
        var productsEntities = await _repository.GetByIdAsync(id);
        return _mapper.Map<ProductDTO>(productsEntities);
    }

    public async Task<IEnumerable<ProductDTO>> GetProducts() {
        var productsEntities = await _repository.GetProductsAsync();
        return _mapper.Map<IEnumerable<ProductDTO>>(productsEntities);
    }

    public async Task Remove(ProductDTO productDTO) {
        var productEntity = _mapper.Map<Product>(productDTO);
        await _repository.RemoveAsync(productEntity);
    }

    public async Task Update(ProductDTO productDTO) {
        var productEntity = _mapper.Map<Product>(productDTO);
        await _repository.UpdateAsync(productEntity);
    }
}
