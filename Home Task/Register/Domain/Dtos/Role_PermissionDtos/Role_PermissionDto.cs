using Domain.Entities;

namespace Domain.Dtos.Role_PermissionDtos;

public class Role_PermissionDto
{
    public int Id { get; set; }
    public int RoleId { get; set; }
    public int PermissionId { get; set; }
    public Role Role { get; set; }
    public Permission Permission { get; set; }
}
