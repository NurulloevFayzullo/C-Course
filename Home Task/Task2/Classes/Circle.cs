
public class Circle
{
    private double _radius;
    private string _color;
    private const double pi = 3.14;

    public Circle()
    {
        
    }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }

    public double GetRadius { get{return _radius;} }
    public string GetColor { get{return _color;} }
    public double GetArea { get{return _radius * _radius * pi;} }
}