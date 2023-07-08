namespace Task2.Point;

public class Circle : Point
{
    Point center = new Point(0, 0);
    double radius = 1.0;
    const double pi = 3.14;
    public Circle()
    {

    }
    public Circle(int x, int y, double radius) : base(x, y)
    {
        this.radius = radius;
    }
    public Circle(Point center, double radius)
    {
        this.center = center;
        this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public Point GetCenter()
    {
        return center;
    }
    public void SetCenter(Point center)
    {
        this.center = center;
    }
    public int GetCenterX()
    {
        return base.GetX();
    }
    public void SetCenterX(int x)
    {
        base.SetX(x);
    }
    public int GetCenterY()
    {
        return base.GetY();
    }
    public void SetCenterY(int y)
    {
        base.SetY(y);
    }
    public int[] GetCenterXY()
    {
        return base.GetXY();
    }
    public void SetCenterXY(int x, int y)
    {
        base.SetXY(x, y);
    }
    public string ToString()
    {
        return $"Circle[center=({base.GetX()},{base.GetY()}),radius={radius}]";
    }
    public double GetArea()
    {
        return pi * radius * radius;
    }
    public double GetCircumference()
    {
        return 2 * pi * radius;
    }
    public double Distance(Circle another)
    {
        return base.Distance(another);
    }
}
