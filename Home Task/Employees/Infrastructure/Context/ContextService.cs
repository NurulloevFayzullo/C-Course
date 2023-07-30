namespace Infrastructure.Context;
using Npgsql;
using Dapper;
public class ContextService
{
    private string _connectionServices = "Server=localhost;Port=5432;Database=Departmentdb;User Id=postgres;Password=Aylin1212;";
    public NpgsqlConnection CreateContext()
    {
    return new NpgsqlConnection(_connectionServices);
    }
}
