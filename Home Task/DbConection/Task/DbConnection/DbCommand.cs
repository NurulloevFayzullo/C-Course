namespace Task.DbConnection;

public class DbCommand
{
    DbConnection connection;
    string message;
    public DbCommand(string message, DbConnection connection)
    {
        this.message = message;
        this.connection = connection;
    }
    public void Execute()
    {
        connection.Open();
        System.Console.WriteLine($"Executed command {message}");
        connection.Close();
    }


}