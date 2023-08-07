namespace Domain.Dtos.PostDtos;

public class PostDtos
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Vote { get; set; }
    public DateTime CreateAt { get; set; }
}
