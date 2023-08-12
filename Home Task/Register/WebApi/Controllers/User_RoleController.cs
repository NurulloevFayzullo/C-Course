using Domain.Dtos.User_RoleDtos;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services.User_RoleServices;
namespace WebApi.Controllers;

public class User_RoleController : ControllerBase
{
     private readonly IUser_RoleServices User_Role;
    public User_RoleController(IUser_RoleServices _User_Role)
    {
        User_Role = _User_Role;

    }
    [HttpGet("GetUser_Roles")]
    public async Task<List<GetUser_RoleDto>> GetUser_Roles()
    {
        return await User_Role.GetUser_Roles();
    }
    [HttpGet("GetUser_RoleById")]
    public async Task<GetUser_RoleDto> GetUser_RoleById(int id)
    {
        return await User_Role.GetUser_RoleById(id);
    }
    [HttpPost("AddUser_Role")]
    public async Task<GetUser_RoleDto> AddUser_Role(AddUser_RoleDto use)
    {
        return await User_Role.AddUser_Role(use);
    }
    [HttpDelete("DeleteUser_Role")]
    public async Task<bool> DeleteUser_Role(int id)
    {
        return await User_Role.DeleteUser_Role(id);
    }
    [HttpPut("UpdateUser_Role")]
    public async Task<GetUser_RoleDto> UpdateUser_Role(AddUser_RoleDto use)
    {
        return await User_Role.UpdateUser_Role(use);
    }
}
