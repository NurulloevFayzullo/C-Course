using Domain.Dtos.Role_PermissionDtos;
using Infrastructure.Services.Role_PermissionServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class Role_PermissionController : ControllerBase
{
      private readonly IRole_PermissionService Role_Permission;
    public Role_PermissionController(IRole_PermissionService _Role_Permission)
    {
        Role_Permission = _Role_Permission;

    }
    [HttpGet("GetRole_Permissions")]
    public async Task<List<GetRole_PermissionDto>> GetRole_Permissions()
    {
        return await Role_Permission.GetRole_Permissions();
    }
    [HttpGet("GetRole_PermissionById")]
    public async Task<GetRole_PermissionDto> GetRole_PermissionById(int id)
    {
        return await Role_Permission.GetRole_PermissionById(id);
    }
    [HttpPost("AddRole_Permission")]
    public async Task<GetRole_PermissionDto> AddRole_Permission(AddRole_PermissionDto use)
    {
        return await Role_Permission.AddRole_Permission(use);
    }
    [HttpDelete("DeleteRole_Permission")]
    public async Task<bool> DeleteRole_Permission(int id)
    {
        return await Role_Permission.DeleteRole_Permission(id);
    }
    [HttpPut("UpdateRole_Permission")]
    public async Task<GetRole_PermissionDto> UpdateRole_Permission(AddRole_PermissionDto use)
    {
        return await Role_Permission.UpdateRole_Permission(use);
    }
}
