namespace Task.Classes;
public abstract class Book
{
    string _name;
    string _author;
    int _price;
    public string Name { get { return _name; } }
    public string Author { get { return _author; } }
    public int Price { get { return _price; } }

    public Book(string name, string author, int price)
    {
        _name = name;
        _author = author;
        _price = price;
    }
    public abstract void GetDetails();
}
