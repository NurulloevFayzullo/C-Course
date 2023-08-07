using Domain.Dtos.StudentDtos;
using Infrustructure.Services.StudentServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class StudentController : ControllerBase
{
    private IStudentService _connection;

    public StudentController(IStudentService _connection)
    {
        this._connection = _connection;
    }

    [HttpGet("GetStudents")]
    public async Task<List<GetStudentDtos>> GetStudents()
    {
        return await _connection.GetStudents();
    }
    [HttpGet("GetStudentById")]
    public async Task<GetStudentDtos> GetStudentById(int id)
    {
        return await _connection.GetStudentById(id);
    }
    [HttpGet("GetStudentCount")]
    public int GetStudentCount()
    {
        return _connection.GetStudentsCount();
    }
    [HttpPost("AddStudent")]
    public async Task<GetStudentDtos> AddStudent(AddStudentDtos student)
    {
        return await _connection.AddStudent(student);
    }
    [HttpDelete("DeleteStudent")]
    public async Task<bool> DeleteStudent(int id)
    {
        return await _connection.DeleteStudent(id);
    }
    [HttpPut("UpdateStudent")]
    public async Task<GetStudentDtos> UpdateStudent(AddStudentDtos student)
    {
        return await _connection.UpdateStudent(student);
    }

}
