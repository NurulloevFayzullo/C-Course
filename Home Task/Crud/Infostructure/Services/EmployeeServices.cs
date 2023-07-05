using System.Collections.Generic;
namespace Infostructure.Services;
using Domain.Models;
public class EmployeeServices
{
    List<Employee> _employees;
    public EmployeeServices()
    {
        _employees = new List<Employee>();
    }
    public List<Employee> GetEmployees()
    {
        return _employees;
    }
    public void Add(Employee employee)
    {
        employee.Id=_employees.Count+1;
        _employees.Add(employee);
    }
    public Employee Update(Employee employee){
        foreach (var e in _employees)
        {
            if (e.Id == employee.Id)
            {
                e.FirstName=employee.FirstName;
                e.LastName=employee.LastName;
                e.BirthDate=employee.BirthDate;
                e.Salary=employee.Salary;
                e.department.Name=employee.department.Name;
                return e;
            }
        }
        return null;
    }
    public void Removee(int Id)
    {
      var e= _employees.FirstOrDefault(e => e.Id == Id);
      _employees.RemoveAt(e.Id-1);
    }
    public int CountEmployees()
    {
        return _employees.Count();
    }
}
