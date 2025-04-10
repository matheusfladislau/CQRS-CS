using AutoMapper;
using CQRSCS.Application.DTOs;
using CQRSCS.Domain.Entities;

namespace CQRSCS.Application.Mappings; 
public class CustomerMapping : Profile {
    public CustomerMapping() {
        CreateMap<Customer, CustomerDTO>().ReverseMap();
    }
}
