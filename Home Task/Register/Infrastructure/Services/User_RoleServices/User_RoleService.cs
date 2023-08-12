using AutoMapper;
using Domain.Dtos.User_RoleDtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.User_RoleServices;

public class User_RoleService : IUser_RoleServices
{
     protected readonly DataContext _context;
    protected readonly IMapper _mapper;
    public User_RoleService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
   
    public async Task<GetUser_RoleDto> AddUser_Role(AddUser_RoleDto user_role)
    {
          var us = _mapper.Map<User_Role>(user_role);
        await _context.User_Roles.AddAsync(us);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetUser_RoleDto>(us);
    }

    public async Task<bool> DeleteUser_Role(int id)
    {
     var us = await _context.User_Roles.FindAsync(id);
        if (us != null)
        {
            _context.User_Roles.Remove(us);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetUser_RoleDto> GetUser_RoleById(int id)
    {
           var us = await _context.User_Roles.FindAsync(id);
        return _mapper.Map<GetUser_RoleDto>(us);
    }

    public async Task<List<GetUser_RoleDto>> GetUser_Roles()
    {
        var conn = await _context.User_Roles.ToListAsync();
        return _mapper.Map<List<GetUser_RoleDto>>(conn);
    }

    public async Task<GetUser_RoleDto> UpdateUser_Role(AddUser_RoleDto User_Role)
    {
               var us = _mapper.Map<User_Role>(User_Role);
       _context.User_Roles.Update(us);
      await _context.SaveChangesAsync();
      return _mapper.Map<GetUser_RoleDto>(us);
    }

}
