using Domain.Dtos.TeacherDtos;
using Domain.Entities;
using Infrustructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Infrustructure.Services.TeacherServices;

public class TeacherService : ITeacherService
{
        private readonly DataContext _context;
    public TeacherService(DataContext _context)
    {
        this._context = _context;

    }

    public async Task<GetTeacherDtos> AddTeacher(AddTeacherDtos teacher)
    {
        var teach = new Teacher()
        {
            Id = teacher.Id,
            Name = teacher.Name,
            Surname = teacher.Surname,
            Experience = teacher.Experience,
            Position = teacher.Position
        };
       await _context.Teachers.AddAsync(teach);
        await _context.SaveChangesAsync();
        return new GetTeacherDtos()
        {
         Id = teacher.Id,
            Name = teacher.Name,
            Surname = teacher.Surname,
            Experience = teacher.Experience,
            Position = teacher.Position
        };
    }

    public async Task<bool> DeleteTeacher(int id)
    {
         var teacher = await _context.Teachers.FindAsync(id);
        if (teacher != null)
        {
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetTeacherDtos> GetTeacherById(int id)
    {
        var teacher = await _context.Teachers.Select(c => new GetTeacherDtos()
        {
            Id = c.Id,
            Name = c.Name,
            Surname = c.Surname,
            Experience = c.Experience,
            Position = c.Position
        }).FirstOrDefaultAsync(c => c.Id == id);
        return teacher;
    }

    public async Task<List<GetTeacherDtos>> GetTeachers()
    {
        var teacher = await _context.Teachers.Select(c => new GetTeacherDtos()
        {
            Id = c.Id,
            Name = c.Name,
            Surname = c.Surname,
            Experience = c.Experience,
            Position = c.Position
        }).ToListAsync();
        return teacher;
    }

    public int GetTeachersCount()
    {
     return _context.Teachers.Count();
    }

    public async Task<GetTeacherDtos> UpdateTeacher(AddTeacherDtos teacher)
    {
        var teach = new Teacher()
        {
          Id = teacher.Id,
            Name = teacher.Name,
            Surname = teacher.Surname,
            Experience = teacher.Experience,
            Position = teacher.Position
        };
     _context.Teachers.Update(teach);
     await _context.SaveChangesAsync();
     return new GetTeacherDtos()
        {
            Id = teacher.Id,
            Name = teacher.Name,
            Surname = teacher.Surname,
            Experience = teacher.Experience,
            Position = teacher.Position
        };
    }

}
