using Domain.Dtos.CourseDtos;
using Infrustructure.Services.CourseSevices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
    private ICourseSevice _connection;

    public CourseController(ICourseSevice _connection)
    {
        this._connection = _connection;
    }

    [HttpGet("GetCourses")]
    public async Task<List<GetCourseDtos>> GetCourses()
    {
        return await _connection.GetCourses();
    }
    [HttpGet("GetCourseById")]
    public async Task<GetCourseDtos> GetCourseById(int id)
    {
        return await _connection.GetCourseById(id);
    }
    [HttpGet("GetCourseCount")]
    public int GetCourseCount()
    {
return _connection.GetCoursesCount();
    }
    [HttpPost("AddCourse")]
    public async Task<GetCourseDtos> AddCourse(AddCourseDtos course)
    {
        return await _connection.AddCourse(course);
    }
    [HttpDelete("DeleteCourse")]
    public async Task<bool> DeleteCourse(int id)
    {
        return await _connection.DeleteCourse(id);
    }
    [HttpPut("UpdateCourse")]
    public async Task<GetCourseDtos> UpdateCourse(AddCourseDtos course)
    {
        return await _connection.UpdateCourse(course);
    }

}
