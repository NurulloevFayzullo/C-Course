using Infrastructure.Services;
using Domain.Classes;
var department = new DepartmentService();
// while (true)
// {
//     System.Console.WriteLine("\n Commands : \n r - all records \n c - for create \n u - for update \n g - for get a row of table");
//     var command = Console.ReadLine();
//     if (command == "r")
//     {
//         foreach (var item in department.GetDepartments())
//         {
//             System.Console.WriteLine("----------------------------------------------------------------------");
//             System.Console.WriteLine($"Department's id={item.Id} Department's name={item.Name} \n Employee's id={item.employeeid} Employee's fullname={item.fullname}");
//         }
//     }
//     else if (command == "c")
//     {
//         Create();
//     }
//     else if (command == "u")
//     {
//         Update();
//     }
//     else if (command == "g")
//     {
//         System.Console.WriteLine("Inter the id which you wanna see = ");
//         var id = Convert.ToInt32(Console.Read());
//         var depart = department.GetDepartmentById(id);
//         System.Console.WriteLine($"Id = {depart.Id}");
//         System.Console.WriteLine($"Name = {depart.Name}");
//     }
// }

// void Create()
// {
//     var depart = new Department();
//     System.Console.Write("Enter your Id = ");
//     depart.Id = Convert.ToInt32(Console.ReadLine());
//     System.Console.Write("Enter your name = ");
//     depart.Name = Console.ReadLine();
//     department.AddDepartment(depart);
// }
// void Update()
// {
//     System.Console.Write($"Enter the id which you wanna edit");
//     var id = Convert.ToInt32(Console.ReadLine());
//     var existing = department.GetDepartmentById(id);
//     var inputName = Console.ReadLine();
//     if (string.IsNullOrEmpty(inputName) == false)
//     {
//         existing.Name = inputName;
//     }
//     department.UpdateDepartment(existing);
// }

// var employee= new EmployeeServices();

// foreach (var item in employee.GetEmployees())
// {
//     System.Console.WriteLine("--------------------------------");
//     System.Console.WriteLine($" Id={item.Id} Fullname={item.Fullname} \n DepartmentId={item.DepartmentId} DepartmentName={item.DepartmentName}");
// }

// var d_employee=new ManagerSevice();
// foreach (var item in d_employee.GetDepartment_Manager())
// {
//    System.Console.WriteLine($"Managerid={item.employeeid} ManagerFullName={item.Fullname} DepartmentId={item.departmentid} DepartmentName={item.name} FromDate={item.fromdate} Todate={item.todate}");
// } 

var depart=new DepartmentService();
depart.DeleteDepartment(1);