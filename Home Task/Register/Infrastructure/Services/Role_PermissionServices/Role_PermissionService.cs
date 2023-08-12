using AutoMapper;
using Domain.Dtos.Role_PermissionDtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Role_PermissionServices;

public class Role_PermissionService : IRole_PermissionService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;
    public Role_PermissionService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<GetRole_PermissionDto> AddRole_Permission(AddRole_PermissionDto role_permission)
    {
                var us = _mapper.Map<Role_Permission>(role_permission);
        await _context.Role_Permissions.AddAsync(us);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetRole_PermissionDto>(us);
    }

    public async Task<bool> DeleteRole_Permission(int id)
    {
        var us = await _context.Role_Permissions.FindAsync(id);
        if (us != null)
        {
            _context.Role_Permissions.Remove(us);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetRole_PermissionDto> GetRole_PermissionById(int id)
    {
        
       var us = await _context.Role_Permissions.FindAsync(id);
        return _mapper.Map<GetRole_PermissionDto>(us);
     
    }

    public async Task<List<GetRole_PermissionDto>> GetRole_Permissions()
    {
        var conn = await _context.Role_Permissions.ToListAsync();
        return _mapper.Map<List<GetRole_PermissionDto>>(conn);
    }

    public async Task<GetRole_PermissionDto> UpdateRole_Permission(AddRole_PermissionDto role_permission)
    {
        var us = _mapper.Map<Role_Permission>(role_permission);
       _context.Role_Permissions.Update(us);
      await _context.SaveChangesAsync();
      return _mapper.Map<GetRole_PermissionDto>(us);
    }

}
