namespace Task2.Shape;
public class Circle : Shape
{
    public double radius;
    private const double pi=3.14;
    public override double Area(){
        return pi*Math.Pow(radius,2);
    }
    public override double Perimeter()
    {
        return 2 * pi * radius;
    }
}