namespace Infrastructure.Services.PermissionServices;
using Domain.Dtos.PermissionDtos;
public interface IPermissionService
{
        public Task<List<GetPermissionDto>> GetPermissions();
    public Task<GetPermissionDto> GetPermissionById(int id);
    public Task<bool> DeletePermission(int id);
    public Task<GetPermissionDto> AddPermission(AddPermissionDto Permission);
    public Task<GetPermissionDto> UpdatePermission(AddPermissionDto Permission);
    
}
