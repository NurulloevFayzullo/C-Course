using Domain.Entities;

namespace Domain.Dtos.User_RoleDtos;

public class User_RoleDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int RoleId { get; set; }
    public User User { get; set; }
    public Role Role { get; set; }
}
