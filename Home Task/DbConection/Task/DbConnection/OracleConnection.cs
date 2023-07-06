using System.Diagnostics;
using System.Threading;
namespace Task.DbConnection;

public class OracleConnection : DbConnection
{
     public OracleConnection(string connectionString) : base(connectionString)
    {
        
    }
    public override void Close()
    {
          System.Console.WriteLine("Oracle connection is closed");
    }

    public override void Open()
    {
        var sw = new Stopwatch();
        sw.Start();
        System.Console.WriteLine("---10%");
        Thread.Sleep(1000);
        System.Console.WriteLine("---40%");
        Thread.Sleep(1000);
        System.Console.WriteLine("---99%");
        Thread.Sleep(1000);
        sw.Stop();

        if ( sw.Elapsed.Seconds > TimeOut.Seconds )
        {
            throw new Exception("Time out");
        }
        else 
        {
            System.Console.WriteLine("Oracle connection is open");
        }
    }
}
