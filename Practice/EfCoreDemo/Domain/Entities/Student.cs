namespace Domain.Entities;

public class Student
{
    public int Id { get; set; }
    public string FirtName { get; set; }
    public string LastName { get; set; }
    public List<StudentGroup> StudentGroups { get; set; }
}
