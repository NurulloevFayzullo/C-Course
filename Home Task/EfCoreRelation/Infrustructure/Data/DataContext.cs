using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
    public DbSet<EmployeeSkill> EmployeeSkills { get; set; }

}
