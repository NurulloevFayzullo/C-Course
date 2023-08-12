using Domain.Dtos.RoleDtos;
using Infrastructure.Services.RoleServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class RoleController : ControllerBase
{
 private readonly IRoleService Role;
    public RoleController(IRoleService _Role)
    {
        Role = _Role;

    }
    [HttpGet("GetRoles")]
    public async Task<List<GetRoleDto>> GetRoles()
    {
        return await Role.GetRoles();
    }
    [HttpGet("GetRoleById")]
    public async Task<GetRoleDto> GetRoleById(int id)
    {
        return await Role.GetRoleById(id);
    }
    [HttpPost("AddRole")]
    public async Task<GetRoleDto> AddRole(AddRoleDto use)
    {
        return await Role.AddRole(use);
    }
    [HttpDelete("DeleteRole")]
    public async Task<bool> DeleteRole(int id)
    {
        return await Role.DeleteRole(id);
    }
    [HttpPut("UpdateRole")]
    public async Task<GetRoleDto> UpdateRole(AddRoleDto use)
    {
        return await Role.UpdateRole(use);
    }
}
