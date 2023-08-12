using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Customer
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(50)]
    public string LastName { get; set; }
    [MaxLength(200)]
    public string Address { get; set; }
    [MaxLength(20)]
    public string Phone { get; set; }
    public string Email { get; set; }
    public List<Order> Orders { get; set; }
}
