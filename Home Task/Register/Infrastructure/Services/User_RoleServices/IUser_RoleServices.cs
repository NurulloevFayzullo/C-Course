namespace Infrastructure.Services.User_RoleServices;
using Domain.Dtos.User_RoleDtos;
public interface IUser_RoleServices
{
        public Task<List<GetUser_RoleDto>> GetUser_Roles();
    public Task<GetUser_RoleDto> GetUser_RoleById(int id);
    public Task<bool> DeleteUser_Role(int id);
    public Task<GetUser_RoleDto> AddUser_Role(AddUser_RoleDto User_Role);
    public Task<GetUser_RoleDto> UpdateUser_Role(AddUser_RoleDto User_Role);
}
