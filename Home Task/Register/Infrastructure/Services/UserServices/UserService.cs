using AutoMapper;
using Domain.Dtos.UserDtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Services.UserServices;

public class UserService : IUserService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;
    public UserService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<GetUserDto> AddUser(AddUserDto user)
    {
        var us = _mapper.Map<User>(user);
        await _context.Users.AddAsync(us);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetUserDto>(us);
    }

    public async Task<bool> DeleteUser(int id)
    {
        var us = await _context.Users.FindAsync(id);
        if (us != null)
        {
            _context.Users.Remove(us);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetUserDto> GetUserById(int id)
    {
        var us = await _context.Users.FindAsync(id);
        return _mapper.Map<GetUserDto>(us);
    }

    public async Task<List<GetUserDto>> GetUsers()
    {
        var conn = await _context.Users.ToListAsync();
        return _mapper.Map<List<GetUserDto>>(conn);
    }

    public async Task<GetUserDto> UpdateUser(AddUserDto user)
    {
       var us = _mapper.Map<User>(user);
       _context.Users.Update(us);
      await _context.SaveChangesAsync();
      return _mapper.Map<GetUserDto>(us);
    }

}
