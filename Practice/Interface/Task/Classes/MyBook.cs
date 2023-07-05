namespace Task.Classes;

public class MyBook : Book
{
    public MyBook(string name, string author, int price) : base(name, author, price){}
    public override void GetDetails()
    {
        System.Console.WriteLine($"{Name}, {Author}, {Price}");
    }
}
