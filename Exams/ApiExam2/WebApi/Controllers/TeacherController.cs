using Domain.Dtos.TeacherDtos;
using Infrustructure.Services.TeacherServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
      private ITeacherService _connection;

    public TeacherController(ITeacherService _connection)
    {
        this._connection = _connection;
    }

    [HttpGet("GetTeachers")]
    public async Task<List<GetTeacherDtos>> GetTeachers()
    {
        return await _connection.GetTeachers();
    }
    [HttpGet("GetTeacherById")]
    public async Task<GetTeacherDtos> GetTeacherById(int id)
    {
        return await _connection.GetTeacherById(id);
    }
    [HttpGet("GetTeacherCount")]
    public int GetTeacherCount()
    {
return _connection.GetTeachersCount();
    }
    [HttpPost("AddTeacher")]
    public async Task<GetTeacherDtos> AddTeacher(AddTeacherDtos teacher)
    {
        return await _connection.AddTeacher(teacher);
    }
    [HttpDelete("DeleteTeacher")]
    public async Task<bool> DeleteTeacher(int id)
    {
        return await _connection.DeleteTeacher(id);
    }
    [HttpPut("UpdateTeacher")]
    public async Task<GetTeacherDtos> UpdateTeacher(AddTeacherDtos teacher)
    {
        return await _connection.UpdateTeacher(teacher);
    }

}
