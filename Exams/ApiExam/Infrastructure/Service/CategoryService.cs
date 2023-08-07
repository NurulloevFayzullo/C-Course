using System.Threading.Tasks;
namespace Infrastructure.Service;
using Domain.Classes;
using Dapper;
public class CategoryService
{
    private DapperContext _connection;
    public CategoryService(DapperContext connection)
    {
        _connection = connection;
        
    }

    public async Task<List<Category>> GetCategories()
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Select * from categories order by id";
            return (await connection.QueryAsync<Category>(sql)).ToList();
        }
    }
    public async Task<Category> AddCategories(Category category)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"insert into categories(id,name) values(@id,@name) returning @id";
            var ct = await connection.ExecuteScalarAsync<int>(sql, category);
            category.Id = ct;
            return category;
        }
    }
    public async Task<int> DeleteCategories(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Delete from categories where id=@id";
            return await connection.ExecuteAsync(sql, new { id });
        }
    }
    public async Task<Category> UpdateCategories(Category category)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Update categories 
                set name=@name
                where id=@id";
            var ct = await connection.ExecuteAsync(sql, category);
            return category;
        }
    }
    public async Task<Category> GetCategoriesById(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            string sql = $"select * from categories where id = @id;";
            var response = await connection.QuerySingleOrDefaultAsync<Category>(sql, new { id });
            return response;
        }
    }
}
