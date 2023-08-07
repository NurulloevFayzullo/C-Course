namespace Domain.Dtos.CourseDtos;

public class CourseDtos
{
    
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Fee { get; set; }
    public bool HasDiscount { get; set; }
}
