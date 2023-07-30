using Npgsql;
using Dapper;

public class TodoService
{
    private DapperContext _context;
    public TodoService()
    {
        _context=new DapperContext();
    }
    public List<Todo> GetTodo()
    {
        using (var connection = _context.Connection)
        {
            return connection.Query<Todo>("Select * from todos").ToList();
        }
    }
    public Todo AddTodo(Todo todo)
    {
     using (var connection=_context.Connection)
     {
        var sql="insert into todos(Id,TaskName,Status) values(@Id,@TaskName,@Status) returning Id=@Id;";
        var conn=connection.ExecuteScalar<int>(sql,todo);
        todo.Id=conn;
        return todo;
     }
    }
}