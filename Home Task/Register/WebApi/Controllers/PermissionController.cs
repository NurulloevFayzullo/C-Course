using Domain.Dtos.PermissionDtos;
using Infrastructure.Services.PermissionServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class PermissionController : ControllerBase
{
      private readonly IPermissionService Permission;
    public PermissionController(IPermissionService _Permission)
    {
        Permission = _Permission;
    }
    [HttpGet("GetPermissions")]
    public async Task<List<GetPermissionDto>> GetPermissions()
    {
        return await Permission.GetPermissions();
    }
    [HttpGet("GetPermissionById")]
    public async Task<GetPermissionDto> GetPermissionById(int id)
    {
        return await Permission.GetPermissionById(id);
    }
    [HttpPost("AddPermission")]
    public async Task<GetPermissionDto> AddPermission(AddPermissionDto use)
    {
        return await Permission.AddPermission(use);
    }
    [HttpDelete("DeletePermission")]
    public async Task<bool> DeletePermission(int id)
    {
        return await Permission.DeletePermission(id);
    }
    [HttpPut("UpdatePermission")]
    public async Task<GetPermissionDto> UpdatePermission(AddPermissionDto use)
    {
        return await Permission.UpdatePermission(use);
    }
}
