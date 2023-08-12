using Domain.Entities;

namespace Domain.Dtos.PermissionDtos;

public class PermissionDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public  List<Role_Permission> Role_Permissions { get; set; }
}
