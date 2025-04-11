using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Application.Interfaces;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Interfaces;

namespace CQRSCS.Application.Services; 
public class OrderProductService : IOrderProductService {
    private readonly IOrderProductsRepository _repository;
    private readonly IMapper _mapper;

    public OrderProductService(IOrderProductsRepository repository,
        IMapper mapper) {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task Add(OrderProductDTO orderProduct) {
        var orderProductEntity = _mapper.Map<OrderProduct>(orderProduct);
        await _repository.AddAsync(orderProductEntity);
    }

    public async Task<IEnumerable<OrderProductDTO>> GetProductsByOrderId(int? orderId) {
        var orderProductsEntities = await _repository.GetProductsByOrderIdAsync(orderId);
        return _mapper.Map<IEnumerable<OrderProductDTO>>(orderProductsEntities);
    }

    public async Task Remove(OrderProductDTO orderProduct) {
        var orderProductEntity = _mapper.Map<OrderProduct>(orderProduct);
        await _repository.RemoveAsync(orderProductEntity);
    }

    public async Task UpdateQuantity(OrderProductDTO orderProduct) {
        var orderProductEntity = _mapper.Map<OrderProduct>(orderProduct);
        await _repository.UpdateQuantityAsync(orderProductEntity);
    }
}
