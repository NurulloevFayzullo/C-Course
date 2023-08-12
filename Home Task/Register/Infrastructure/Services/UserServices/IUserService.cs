using Domain.Dtos.UserDtos;

namespace Infrastructure.Services.UserServices;

public interface IUserService
{
    public Task<List<GetUserDto>> GetUsers();
    public Task<GetUserDto> GetUserById(int id);
    public Task<bool> DeleteUser(int id);
    public Task<GetUserDto> AddUser(AddUserDto user);
    public Task<GetUserDto> UpdateUser(AddUserDto user);
    

}
