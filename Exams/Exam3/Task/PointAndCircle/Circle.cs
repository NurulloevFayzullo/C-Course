public class Circle : Point
{
    Point center = new Point(0, 0);
    double radius = 1.0;
    protected const double pi = 3.14;
    public Circle() { }
    public Circle(int xCenter, int yCenter, double radius) :
     base(xCenter,yCenter)
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
        return center.GetX();
    }
    public void SetCenterX(int x)
    {
        center.SetX(x);
    }
    public int GetCenterY()
    {
        return center.GetY();
    }
    public void SetCenterY(int y)
    {
        center.SetY(y);
    }
    public int[] GetCenterXY()
    {
        return center.GetXY();
    }
    public void SetCenterXY(int x, int y)
    {
        center.SetXY(x, y);
    }
    public string toString()
    {
        return $"Circle[center=({center.GetX()},{center.GetY()}),radius={radius}]";
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
        return center.Distance(another);
    }
}
