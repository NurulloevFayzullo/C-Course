using AutoMapper;
using Domain.Dtos.PermissionDtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Services.PermissionServices;

public class PermissionService : IPermissionService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;
    public PermissionService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<GetPermissionDto> AddPermission(AddPermissionDto permission)
    {
                    var us = _mapper.Map<Permission>(permission);
        await _context.Permissions.AddAsync(us);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetPermissionDto>(us);
    }

    public async Task<bool> DeletePermission(int id)
    {
        var us = await _context.Permissions.FindAsync(id);
        if (us != null)
        {
            _context.Permissions.Remove(us);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetPermissionDto> GetPermissionById(int id)
    {
     
       var us = await _context.Permissions.FindAsync(id);
        return _mapper.Map<GetPermissionDto>(us);
    }

    public async Task<List<GetPermissionDto>> GetPermissions()
    {
        var conn = await _context.Permissions.ToListAsync();
        return _mapper.Map<List<GetPermissionDto>>(conn);
    }

    public async Task<GetPermissionDto> UpdatePermission(AddPermissionDto permission)
    {
        var us = _mapper.Map<Permission>(permission);
       _context.Permissions.Update(us);
      await _context.SaveChangesAsync();
      return _mapper.Map<GetPermissionDto>(us);
    }
}
