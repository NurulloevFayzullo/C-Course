using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Teacher
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50),Required]
    public string Name { get; set; }
    [MaxLength(50),Required]
    public string Surname { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }
}
