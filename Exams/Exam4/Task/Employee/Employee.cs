namespace Task.Employee;

public class Employee
{
    int id;
    string firstname;
    string lastname;
    int salary;
    public Employee(int id, string firstname, string lastname, int salary)
    {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.salary = salary;
    }
    public int GetId()
    {
        return id;
    }
    public string GetFirstName()
    {
        return firstname;
    }
    public string GetLastName()
    {
        return lastname;
    }
    public string GetName(){
        return $"{firstname} {lastname}";
    }
    public int GetSalary()
    {
        return salary;
    }
    public void SetSalary(int salary)
    {
        this.salary = salary;
    }
    public int GetAnnualSalary()
    {
      return salary * 12;
    }
    public int RaiseSalary(int percent)
    {
        salary += percent;
        return salary;
    }
    public string ToString()
    {
        return $"Employee[id={id},name={firstname} {lastname},salary={salary}]";
    }
}
