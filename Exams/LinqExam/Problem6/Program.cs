using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Intrinsics.X86;
using Problem6.Class;

var employees = new List<Employee>
{
 new Employee { Name = "Alice", Department = "Sales", Salary = 50000
},
 new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
 new Employee { Name = "Charlie", Department = "Sales", Salary =
55000 },
 new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
 new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
};
var result = (from l in employees
              group l by l.Department into l2
              select new
              {
                  Department=l2.Key,
                  Avarage = l2.Average(av => av.Salary)
              });
foreach (var item in result)
{
    System.Console.WriteLine(item);
}