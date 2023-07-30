namespace Infrastructure.Service;
using Domain.Classes;
using Dapper;
public class CategoryService
{
    private DapperContext _connection;
    public CategoryService()
    {
        _connection = new DapperContext();
    }

    public List<Category> GetCategories()
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Select * from categories order by id";
            return connection.Query<Category>(sql).ToList();
        }
    }
    public List<Category> GetCategoryId(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"select q.id,q.author,c.name,q.QuoteText,q.Categoryid
                from categories as c
                join quotes as q
                on c.id=q.categoryid
                where q.categoryid=@id;";
            var e= connection.Query<Category>(sql, new { id }).ToList();
            return e;
            
        }
    }
    public Category AddCategories(Category category)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"insert into categories(id,name) values(@id,@name) returning @id";
            var ct = connection.ExecuteScalar<int>(sql, category);
            category.Id = ct;
            return category;
        }
    }
    public int DeleteCategories(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Delete from categories where id=@id";
            return connection.Execute(sql, new { id });
        }
    }
    public Category UpdateCategories(Category category)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Update categories 
                set name=@name
                where id=@id";
            var ct = connection.Execute(sql, category);
            return category;
        }
    }
    public Category GetCategoriesById(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            string sql = $"select * from categories where id = @id;";
            var response = connection.QuerySingleOrDefault<Category>(sql, new { id });
            return response;
        }
    }
}
