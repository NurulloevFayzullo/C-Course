using System;
namespace Domain.Classes;

public class Department_manager : Employee
{
    public int employeeid { get; set; }
    public int departmentid { get; set; }
    public DateTime fromdate { get; set; }
    public DateTime todate { get; set; }
}