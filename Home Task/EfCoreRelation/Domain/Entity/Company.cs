namespace Domain.Entity;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Company> Companies { get; set; }
}
