namespace Domain.Entities;

public class Group
{
    public int Id { get; set; }
  public string Name { get; set; }
  public List<StudentGroup> StudentGroups { get; set; }
}