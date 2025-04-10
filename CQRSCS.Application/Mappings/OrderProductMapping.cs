using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Domain.Entities;

namespace CQRSCS.Application.Mappings; 
public class OrderProductMapping : Profile {
    public OrderProductMapping() {
        CreateMap<OrderProduct, OrderProductDTO>().ReverseMap(); 
    }
}
