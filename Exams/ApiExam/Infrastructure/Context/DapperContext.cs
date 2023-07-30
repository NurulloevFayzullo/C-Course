using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;

public class DapperContext
{
   private string connectionString = "Server=Localhost; port=5432; database=Quotedb; User Id=postgres; password=Aylin1212";
    
    public NpgsqlConnection CreateConnection()
    {
        return new NpgsqlConnection(connectionString);
    }
}