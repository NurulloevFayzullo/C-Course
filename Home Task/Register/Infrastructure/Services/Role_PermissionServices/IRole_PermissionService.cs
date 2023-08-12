namespace Infrastructure.Services.Role_PermissionServices;
using Domain.Dtos.Role_PermissionDtos;
public interface IRole_PermissionService
{
        public Task<List<GetRole_PermissionDto>> GetRole_Permissions();
    public Task<GetRole_PermissionDto> GetRole_PermissionById(int id);
    public Task<bool> DeleteRole_Permission(int id);
    public Task<GetRole_PermissionDto> AddRole_Permission(AddRole_PermissionDto Role_Permission);
    public Task<GetRole_PermissionDto> UpdateRole_Permission(AddRole_PermissionDto Role_Permission);
}
