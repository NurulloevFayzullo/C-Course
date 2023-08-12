using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    [MaxLength(200)]
    public string Email { get; set; }
    [MaxLength(100)]
    public string Full_Name { get; set; }
    public List<User_Role> User_Roles { get; set; }
}
