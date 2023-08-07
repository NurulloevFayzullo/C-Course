using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Post
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Vote { get; set; }
    public DateTime CreateAt { get; set; }
}
