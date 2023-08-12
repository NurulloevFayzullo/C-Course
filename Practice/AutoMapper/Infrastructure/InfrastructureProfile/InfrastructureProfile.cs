using AutoMapper;
using Domain.Dtos.Customer;
using Domain.Entity;


namespace Infrastructure.InfrastructureProfile;

public class InfrastructureProfile : Profile
{
    public InfrastructureProfile()
    {
        CreateMap<Customer,GetCustomerDto>();
        CreateMap<AddCustomerDto,Customer>();
        
    }
}
