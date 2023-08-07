using Domain.Dtos.StudentDtos;
using Domain.Entities;
using Infrustructure.Data
;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Services.StudentServices;

public class StudentService : IStudentService
{
       private readonly DataContext _context;


    public StudentService(DataContext _context)
    {
        this._context = _context;

    }
    public async Task<GetStudentDtos> AddStudent(AddStudentDtos student)
    {
       var studen = new Student()
        {
            Id = student.Id,
             FirstName=student.FirstName,
            LastName=student.LastName,
            FatherName=student.FatherName,
            Address=student.Address,
            Birthdate=student.Birthdate,
            Phone=student.Phone
        };
       await _context.Students.AddAsync(studen);
        await _context.SaveChangesAsync();
        return new GetStudentDtos()
        {
          Id = student.Id,
             FirstName=student.FirstName,
            LastName=student.LastName,
            FatherName=student.FatherName,
            Address=student.Address,
            Birthdate=student.Birthdate,
            Phone=student.Phone
        };
    }

    public async Task<bool> DeleteStudent(int id)
    {
     var student = await _context.Students.FindAsync(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetStudentDtos> GetStudentById(int id)
    {
           var student = await _context.Students.Select(c => new GetStudentDtos()
        {
             Id = c.Id,
             FirstName=c.FirstName,
            LastName=c.LastName,
            FatherName=c.FatherName,
            Address=c.Address,
            Birthdate=c.Birthdate,
            Phone=c.Phone
        }).FirstOrDefaultAsync(c => c.Id == id);
        return student;
    }

    public async Task<List<GetStudentDtos>> GetStudents()
    {
     var student = await _context.Students.Select(c => new GetStudentDtos()
        {
            Id = c.Id,
            FirstName=c.FirstName,
            LastName=c.LastName,
            FatherName=c.FatherName,
            Address=c.Address,
            Birthdate=c.Birthdate,
            Phone=c.Phone
        }).ToListAsync();
        return student;
    }

    public int GetStudentsCount()
    {
        return _context.Students.Count();
    }

    public async Task<GetStudentDtos> UpdateStudent(AddStudentDtos student)
    {
         var studen = new Student()
        {
          Id = student.Id,
             FirstName=student.FirstName,
            LastName=student.LastName,
            FatherName=student.FatherName,
            Address=student.Address,
            Birthdate=student.Birthdate,
            Phone=student.Phone
        };
     _context.Students.Update(studen);
     await _context.SaveChangesAsync();
     return new GetStudentDtos()
        {
           Id = student.Id,
             FirstName=student.FirstName,
            LastName=student.LastName,
            FatherName=student.FatherName,
            Address=student.Address,
            Birthdate=student.Birthdate,
            Phone=student.Phone
        };
    }

}
