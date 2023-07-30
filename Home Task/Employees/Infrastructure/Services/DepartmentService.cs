namespace Infrastructure.Services;
using Domain.Classes;
using Npgsql;
using Dapper;
using Infrastructure.Context;
using Domain.Dtos;
public class DepartmentService
{
    private ContextService _context;
    public DepartmentService()
    {
        _context = new ContextService();
    }
    public List<DepartmentDto> GetDepartments()
    {
        using (var connection = _context.CreateContext())
        {
            string sql = @"select * from departments";
            return connection.Query<DepartmentDto>(sql).ToList();
        }
    }
    public DepartmentDto GetDepartmentById(int id)
    {
        using (var connection = _context.CreateContext())
        {
            string sql = @"select d.id,d.name,e.id as employeeid,concat(e.firstname,' ',e.lastname) as firstname
                from departments as d
                join department_managers as dm
                on dm.departmentid=d.id
                join employees as e 
                on dm.employeeid=e.id
                where d.id=@id";
            return connection.QuerySingleOrDefault<DepartmentDto>(sql, new { id });
        }
    }
    public DepartmentDto AddDepartment(DepartmentDto department)
    {
        using (var connection = _context.CreateContext())
        {
            var sql = @"insert into departments(id,name)
                values(@id,@name) returning @id;";
            var conn = connection.ExecuteScalar<int>(sql, department);
            department.Id = conn;
            return department;
        }
    }
    public DepartmentDto UpdateDepartment(DepartmentDto department)
    {
        using (var connection = _context.CreateContext())
        {
            var sql = @"update departments
                set name=@name
                where id=@id";
            var con= connection.Execute(sql, department);
            return department;
        }
    }
    public int DeleteDepartment(int id)
    {
        using (var connection=_context.CreateContext())
        {
   var sql=@"Delete from departments where id=@id";
   return connection.Execute(sql,new{id});         
        }
    }
}
