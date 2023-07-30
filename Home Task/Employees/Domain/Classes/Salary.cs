namespace Domain.Classes;

public class Salary
{
    public int Id { get; set; }
    public int employeeid { get; set; }
    public int amount { get; set; }
    public DateTime fromdate { get; set; }
    public DateTime todate { get; set; }
}
