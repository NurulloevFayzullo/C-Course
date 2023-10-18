namespace Domain.Dtos.UseProfileDtos;

public class UserProfileDto
{
    public int UserProfileId { get; set; }
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int LocationId { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Accupation { get; set; }
    public string About { get; set; }
    public DateTime DateUpdated { get; set; }
}