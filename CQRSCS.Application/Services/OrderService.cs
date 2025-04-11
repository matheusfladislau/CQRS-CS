using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Application.Interfaces;
using CQRSCS.Domain.Entities;
using CQRSCS.Domain.Enums;
using CQRSCS.Domain.Interfaces;

namespace CQRSCS.Application.Services; 
public class OrderService : IOrderService {
    private readonly IOrderRepository _repository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository repository,
        IMapper mapper) {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task Add(OrderDTO order) {
        var orderEntity = _mapper.Map<Order>(order);
        await _repository.AddAsync(orderEntity);
    }

    public async Task<OrderDTO> GetById(int? id) {
        var orderEntity = await _repository.GetByIdAsync(id);
        return _mapper.Map<OrderDTO>(orderEntity);
    }

    public async Task<IEnumerable<OrderDTO>> GetByStatus(OrderStatus status) {
        var orderEntities = await _repository.GetByStatusAsync(status);
        return _mapper.Map<IEnumerable<OrderDTO>>(orderEntities);
    }

    public async Task<IEnumerable<OrderDTO>> GetOrders() {
        var orderEntities = await _repository.GetOrdersAsync();
        return _mapper.Map<IEnumerable<OrderDTO>>(orderEntities);
    }

    public async Task Remove(OrderDTO order) {
        var orderEntity = _mapper.Map<Order>(order);
        await _repository.RemoveAsync(orderEntity);
    }

    public async Task Update(OrderDTO order) {
        var orderEntity = _mapper.Map<Order>(order);
        await _repository.UpdateAsync(orderEntity);
    }

    public async Task UpdateStatus(OrderDTO order, OrderStatus status) {
        var orderEntity = _mapper.Map<Order>(order);
        await _repository.UpdateStatusAsync(orderEntity, status);
    }
}
