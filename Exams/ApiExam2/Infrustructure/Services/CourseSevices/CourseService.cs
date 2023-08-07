using Domain.Dtos.CourseDtos;
using Domain.Entities;
using Infrustructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Services.CourseSevices;

public class CourseService : ICourseSevice
{
    private readonly DataContext _context;
    public CourseService(DataContext _context)
    {
        this._context = _context;

    }
    public async Task<List<GetCourseDtos>> GetCourses()
    {
        var course = await _context.Courses.Select(c => new GetCourseDtos()
        {
            Id = c.Id,
            Title = c.Title,
            Description = c.Description,
            Fee = c.Fee,
            HasDiscount = c.HasDiscount
        }).ToListAsync();
        return course;
    }
    public async Task<GetCourseDtos> AddCourse(AddCourseDtos course)
    {
        var cour = new Course()
        {
            Id = course.Id,
            Description = course.Description,
            Fee = course.Fee,
            HasDiscount = course.HasDiscount,
            Title = course.Title
        };
       await _context.Courses.AddAsync(cour);
        await _context.SaveChangesAsync();
        return new GetCourseDtos()
        {
            Id = course.Id,
            Description = course.Description,
            Fee = course.Fee,
            HasDiscount = course.HasDiscount,
            Title = course.Title
        };
    }

    public int GetCoursesCount()
    {
     return _context.Courses.Count();
    }

    public async Task<bool> DeleteCourse(int id)
    {
        var course = await _context.Courses.FindAsync(id);
        if (course != null)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetCourseDtos> GetCourseById(int id)
    {
        var coure = await _context.Courses.Select(c => new GetCourseDtos()
        {
            Id = c.Id,
            Title = c.Title,
            Description = c.Description,
            Fee = c.Fee,
            HasDiscount = c.HasDiscount
        }).FirstOrDefaultAsync(c => c.Id == id);
        return coure;
    }


    public async Task<GetCourseDtos> UpdateCourse(AddCourseDtos course)
    {
        var cour = new Course()
        {
          Id = course.Id,
            Description = course.Description,
            Fee = course.Fee,
            HasDiscount = course.HasDiscount,
            Title = course.Title
        };
     _context.Courses.Update(cour);
     await _context.SaveChangesAsync();
     return new GetCourseDtos()
        {
            Id = course.Id,
            Description = course.Description,
            Fee = course.Fee,
            HasDiscount = course.HasDiscount,
            Title = course.Title
        };
    }

}
