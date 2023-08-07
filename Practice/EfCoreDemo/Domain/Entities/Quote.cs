namespace Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Quote
{
    [Key]
    public int Id { get; set; }
    [MaxLength(200),Required]
    public string Author { get; set; }
    [MaxLength(50),Required]
    public string QuoteText { get; set; }
    public string? ImageName { get; set; }
    public DateTime CreateAt { get; set; }
}
