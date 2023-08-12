using AutoMapper;
using Domain.Dtos.UserDtos;
using Domain.Entities;


namespace Infrastructure.InfrastructureProfile;

public class InfrastructureProfile : Profile
{
    public InfrastructureProfile()
    {
        CreateMap<AddUserDto,User>();
        CreateMap<User,GetUserDto>();
    }
}
