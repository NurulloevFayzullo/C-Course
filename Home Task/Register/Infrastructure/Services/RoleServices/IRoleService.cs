namespace Infrastructure.Services.RoleServices;
using Domain.Dtos.RoleDtos;
public interface IRoleService
{
        public Task<List<GetRoleDto>> GetRoles();
    public Task<GetRoleDto> GetRoleById(int id);
    public Task<bool> DeleteRole(int id);
    public Task<GetRoleDto> AddRole(AddRoleDto Role);
    public Task<GetRoleDto> UpdateRole(AddRoleDto Role);
}
