using System;
namespace Infrastruction.Data;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentGroup>().HasKey(sg => new { sg.StudentId, sg.GroupId });
     base.OnModelCreating(modelBuilder);
    }
    public DbSet<Quote> Quotes { get; set; }
}
