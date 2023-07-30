namespace Infrastructure.Services;
using Dapper;
using Npgsql;
using Infrastructure.Context;
using Domain.Classes;
public class EmployeeServices
{
    private ContextService _context;
    public EmployeeServices()
    {
        _context = new ContextService();
    }
    public List<Employee> GetEmployees()
    {
using (var connection = _context.CreateContext())
        {
            string sql = @"select e.id, concat(e.firstname, ' ', e.lastname) as Fullname, 
                    dm.departmentid as departmentid, d.name as departmentname
                    from employees as e
                    join department_managers as dm
                    on dm.employeeid = e.id
                    join departments as d
                    on dm.departmentid = d.id;";
            return connection.Query<Employee>(sql).ToList();
        }
    }

    
    public Employee GetEmployeeById(int id)
    {
        using (var connection = _context.CreateContext())
        {
            string sql = @"select e.id, concat(e.firstname, ' ', e.lastname) as Fullname, 
                    dm.departmentid as departmentid, d.name as departmentname
                    from employees as e
                    join department_managers as dm
                    on dm.employeeid = e.id
                    join departments as d
                    on dm.departmentid = d.id;
                where d.id=@id";
            return connection.QuerySingleOrDefault<Employee>(sql, new { id });
        }
    }
    public Employee AddEmployee(Employee employee)
    {
        using (var connection = _context.CreateContext())
        {
            var sql = @"insert into employees(id,birthdate,Firstname,Lastname,hiredate,gender)
                values(@id,@birthdate,@Firstname,@Lastname,@hiredate,@gender) returning @id;";
            var conn = connection.ExecuteScalar<int>(sql, employee);
            employee.Id = conn;
            return employee;
        }
    }
    public int UpdateEmployee(Employee employee)
    {
     using (var connection=_context.CreateContext())
     {
        var sql=@"update employees
                set birthdate=@birthdate,Firstname=@Firstname,
                Lastname=@Lastname, hiredate=@hiredate,gender=@gender
                where id=@id";
       return connection.Execute(sql,employee);
     }
    }
}
