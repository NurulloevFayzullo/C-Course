using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Role
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<User_Role> User_Roles { get; set; }
    public List<Role_Permission> Role_Permissions { get; set; }
}
