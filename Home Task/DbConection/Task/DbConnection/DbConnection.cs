using System;
namespace Task.DbConnection;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan TimeOut { get; set; }
    public DbConnection(string connectionString)
    {
        connectionString = connectionString;
    }
    public abstract void Open();
    public abstract void Close();
}
