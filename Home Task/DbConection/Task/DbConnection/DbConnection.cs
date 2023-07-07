using System;
namespace Task.DbConnection;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan TimeOut { get; set; }
    public DbConnection(string connectionString, TimeSpan timeout)
    {
        ConnectionString = connectionString;
        TimeOut = timeout;

    }
    public abstract void Open();
    public abstract void Close();
}
