using Domain.Entities;

namespace Domain.Dtos.RoleDtos;

public class RoleDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<User_Role> User_Roles { get; set; }
    public List<Role_Permission> Role_Permissions { get; set; }
}
