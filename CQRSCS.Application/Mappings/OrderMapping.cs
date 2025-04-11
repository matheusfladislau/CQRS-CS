using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Domain.Entities;

namespace CQRSCS.Application.Mappings; 
public class OrderMapping : Profile {
    public OrderMapping() {
        CreateMap<Order, OrderDTO>().ReverseMap();
    }
}
