namespace Task2.Animal;

public abstract class Animal
{
    public string Name { get; set; }

    public string GetName() { return Name; }
    public void SetName(string name)
    {
        Name = name;
    }
    public abstract string Eat();
}
