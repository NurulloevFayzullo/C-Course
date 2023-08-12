using AutoMapper;
using Domain.Dtos.RoleDtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.RoleServices;

public class RoleService : IRoleService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;
    public RoleService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
   
    public async Task<GetRoleDto> AddRole(AddRoleDto role)
    {
        var us = _mapper.Map<Role>(role);
        await _context.Roles.AddAsync(us);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetRoleDto>(us);

    }

    public async Task<bool> DeleteRole(int id)
    {
        var us = await _context.Roles.FindAsync(id);
        if (us != null)
        {
            _context.Roles.Remove(us);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetRoleDto> GetRoleById(int id)
    {
       var us = await _context.Roles.FindAsync(id);
        return _mapper.Map<GetRoleDto>(us);
            }

    public async Task<List<GetRoleDto>> GetRoles()
    {
            var conn = await _context.Roles.ToListAsync();
        return _mapper.Map<List<GetRoleDto>>(conn);
    }

    public async Task<GetRoleDto> UpdateRole(AddRoleDto role)
    {
        var us = _mapper.Map<Role>(role);
       _context.Roles.Update(us);
      await _context.SaveChangesAsync();
      return _mapper.Map<GetRoleDto>(us);
    }

}
