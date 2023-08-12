using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Order
{
    [Key]
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime OrderFulfiled { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
    
}
