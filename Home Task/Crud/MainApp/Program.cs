using Infostructure.Services;
using Domain.Models;
var employeeServices=new EmployeeServices();

var emp1=new Employee(){
  FirstName="John",
   LastName="Johnov",
   Salary=100,
   BirthDate=new DateTime(2000,1,1),
   department=new Department(){
     Name="IT",
     Description ="awdawd",
   }
};
var emp2=new Employee(){
  FirstName="John1",
   LastName="Johnov1",
   Salary=1002,
   BirthDate=new DateTime(2002,12,22),
   department=new Department(){
     Name="IT",
     Description ="awdaffa",
   }
};
employeeServices.Add(emp1);
employeeServices.Add(emp2);
//////////////////////////////////////////////////////////////Update
var update=new Employee(){
    Id=1,
    FirstName="Fayzullo",
   LastName="Nurulloev",
   Salary=100000,
   BirthDate=new DateTime(2006,12,22),
   department=new Department(){
     Name="IT",
     Description ="awdaffa",
   }
};
employeeServices.Update(update);
///////////////////////////////////////////////////////////Delete
employeeServices.Removee(2);
foreach (var e in employeeServices.GetEmployees())
{
    System.Console.WriteLine($"{e.Id} {e.FirstName} {e.LastName} {e.Salary} {e.BirthDate.ToShortDateString()} ");
}