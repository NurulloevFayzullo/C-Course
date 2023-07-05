using Infrastructure.Services;
using Domain.Models;
var employeeService=new EmployeeService();

for (int i = 0; i < 2; i++)
{
    var emp=new Employee();
    System.Console.WriteLine($"Employee {i+1}");
    System.Console.Write("Enter your Name:");
  emp.Firstname=Console.ReadLine(); 
    System.Console.Write("Enter your Surname:");
  emp.Lastname=Console.ReadLine();
    System.Console.Write("Enter your Salary:");
  emp.Salary=int.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter year, month and day of your birthDay:");
    int year=int.Parse(Console.ReadLine());
    int month=int.Parse(Console.ReadLine());
    int day=int.Parse(Console.ReadLine());
  emp.BirthDate=new DateTime(year,month,day);
  emp.department=new Department();
  System.Console.WriteLine($"Enter your department name");
  emp.department.Name=Console.ReadLine();

employeeService.addEmployees(emp);
}



foreach (var item in employeeService.getEmployees())
{
    System.Console.WriteLine("----------------------------------------------------------------");
    System.Console.WriteLine($"FirstName:{item.Firstname}");
    System.Console.WriteLine($"LastName:{item.Lastname}");
    System.Console.WriteLine($"Salary:{item.Salary}");
    System.Console.WriteLine($"Birthday:{item.BirthDate.ToShortDateString()}");
    System.Console.WriteLine($"Department Name:{item.department.Name}");
   
}

