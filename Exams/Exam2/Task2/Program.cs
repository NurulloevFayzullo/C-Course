
double first;
double second;
string psmd;
while (true)
{
    System.Console.Write($"The first number is : ");
    first = Convert.ToDouble(Console.ReadLine());

    System.Console.Write($"The operation is : ");
    psmd = Console.ReadLine();

    System.Console.Write($"The second number is : ");
    second = Convert.ToDouble(Console.ReadLine());
    var cal = new Calculator(first, second);

    if (psmd == "+")
    {
       System.Console.Write($"{first}+{second}=");
        System.Console.WriteLine(cal.Sum());
    }
    else if (psmd == "-")
    {
        System.Console.Write($"{first}-{second}=");
        System.Console.WriteLine(cal.Subtract());
    }
    else if (psmd == "*")
    {
        System.Console.Write($"{first}*{second}=");
        System.Console.WriteLine(cal.Multiplication());
    }
    else if (psmd == "/")
    {
        System.Console.Write($"{first}/{second}=");
        System.Console.WriteLine(cal.Division());
    }
}






public class Calculator
{
    double _firstnumber;
    double _secondnumber;

    public Calculator(double firstnumber, double secondnumber)
    {
        _firstnumber = firstnumber;
        _secondnumber = secondnumber;
    }
    public double Sum()
    {
        return _firstnumber + _secondnumber;
    }
    public double Subtract()
    {
        return _firstnumber - _secondnumber;
    }
    public double Multiplication()
    {
        return _firstnumber * _secondnumber;

    }
    public double Division()
    {
        return _firstnumber / _secondnumber;
    }
}


