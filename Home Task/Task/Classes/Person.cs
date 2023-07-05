public class Person
{
    public string firstName;
    public string lastName;
    public int age=13;
    public string address;
    public DateTime birthDate=new DateTime(2023,06,21);
    
    public void FullName()
    {
      System.Console.WriteLine($"{firstName} {lastName}");
    }
    public void getYear(){
        System.Console.WriteLine($"My birth year is {birthDate.Year-age}");
    }
    }