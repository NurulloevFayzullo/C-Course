namespace Infrastruction.Data;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Quote> Quotes {get;set;}
}
