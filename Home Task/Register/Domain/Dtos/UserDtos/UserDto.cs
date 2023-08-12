using Domain.Entities;

namespace Domain.Dtos.UserDtos;

public class UserDto
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Full_Name { get; set; }
    public List<User_Role> User_Roles { get; set; }
}
