namespace Domain.Classes;

public class Employee 
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Fullname { get; set; }
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public DateTime Birthdate { get; set; }
    public int gender { get; set; }
    public DateTime hiredate { get; set; }
}
