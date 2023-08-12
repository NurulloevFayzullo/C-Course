using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Role_Permission> Role_Permissions { get; set; }
    public DbSet<User_Role> User_Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
}
