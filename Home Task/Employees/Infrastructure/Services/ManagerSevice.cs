namespace Infrastructure.Services;
using Dapper;
using Npgsql;
using Domain.Classes;
using Infrastructure.Context;
public class ManagerSevice
{
    private ContextService _context;
    public ManagerSevice()
    {
        _context = new ContextService();
    }
    public List<Department_employee> GetDepartment_Manager()
    {
    using (var connection=_context.CreateContext())
    {
        var sql=@"select e.id as employeeid,concat(e.firstname,' ',e.lastname) as Fullname,
                  d.id as departmentid,d.name as name,ms.fromdate,ms.todate
                  from department_employees as ms
                  join employees as e
                  on ms.employeeid=e.id
                  join departments as d
                  on ms.departmentid=d.id";
         return connection.Query<Department_employee>(sql).ToList();
    }
    }
}
