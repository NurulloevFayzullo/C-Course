using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Permission
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    public  List<Role_Permission> Role_Permissions { get; set; }
}
