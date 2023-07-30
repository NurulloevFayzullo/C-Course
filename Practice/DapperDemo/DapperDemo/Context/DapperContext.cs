using Npgsql;
public class DapperContext
{
    private string _connectionString = "Server=localhost;Port=5432;Database=Tododb;User Id=postgres;Password=Aylin1212;";
    
    public NpgsqlConnection  CreateConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }
    public NpgsqlConnection Connection => new NpgsqlConnection(_connectionString);
}