namespace Infrastructure.Services;
using Domain.Models;
public class EmployeeService
{
    private List<Employee> _employees;
  public EmployeeService()
    {
        _employees = new List<Employee>();
    }
    public List<Employee> getEmployees(){
        return _employees;
    }
    public void addEmployees(Employee employee){
        _employees.Add(employee);
    }
   
    public void CountEmployees(){
        System.Console.WriteLine( _employees.Count);
    }
   
}
