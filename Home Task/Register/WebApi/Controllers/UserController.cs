using Domain.Dtos.UserDtos;
using Infrastructure.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class UserController : ControllerBase
{
    private readonly IUserService user;
    public UserController(IUserService _user)
    {
        user = _user;

    }
    [HttpGet("GetUsers")]
    public async Task<List<GetUserDto>> GetUsers()
    {
        return await user.GetUsers();
    }
    [HttpGet("GetUserById")]
    public async Task<GetUserDto> GetUserById(int id)
    {
        return await user.GetUserById(id);
    }
    [HttpPost("AddUser")]
    public async Task<GetUserDto> AddUser(AddUserDto use)
    {
        return await user.AddUser(use);
    }
    [HttpDelete("DeleteUser")]
    public async Task<bool> DeleteUser(int id)
    {
        return await user.DeleteUser(id);
    }
    [HttpPut("UpdateUser")]
    public async Task<GetUserDto> UpdateUser(AddUserDto use)
    {
        return await user.UpdateUser(use);
    }
}
