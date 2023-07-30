using System.Net;
namespace WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;
using Domain.Dtos;
public class DepartmentController : ControllerBase
{
    private DepartmentService _contactServices;
    public DepartmentController()
    {
        _contactServices = new DepartmentService();
    }
    [HttpGet("GetDepartmentById")]
    public DepartmentDto GetDepartmentById(int id){
    return _contactServices.GetDepartmentById(id);
    }
    [HttpGet("GetDepartments")]
    public List<DepartmentDto> GetDepartments()
    {
        return _contactServices.GetDepartments();
    }
    [HttpPost("AddDepartments")]
    public DepartmentDto AddDepartments(DepartmentDto department)
    {
        return _contactServices.AddDepartment(department);
    }
    [HttpDelete("DeleteDepartments")]
    public int DeleteDepartments(int id)
    {
        return _contactServices.DeleteDepartment(id);
    }
    [HttpPut("UpdateDepartments")]
    public DepartmentDto UpdateDepartments(DepartmentDto department)
    {
    return _contactServices.UpdateDepartment(department);
    }
}
