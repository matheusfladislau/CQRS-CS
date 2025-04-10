using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Domain.Entities;

namespace CQRSCS.Application.Mappings; 
public class ProductMapping : Profile {
    public ProductMapping() {
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
