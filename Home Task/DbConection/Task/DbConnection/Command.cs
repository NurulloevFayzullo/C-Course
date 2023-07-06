namespace Task.DbConnection;

public class Command : DbConnection
{
    string message;
     public Command(string message,string connectionString) : base(connectionString)
     {
        this.message=message;
     }

    public override void Close()
    {
        throw new NotImplementedException();
    }

    public override void Open()
    {
        throw new NotImplementedException();
    }
}