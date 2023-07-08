using System;
namespace Task2.Point;

public class Point
{
    int x = 0;
    int y = 0;
    public Point()
    {

    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int GetX()
    {
        return x;
    }
    public void SetX(int x)
    {
        this.x = x;
    }
    public int GetY()
    {
        return y;
    }
    public void SetY(int y)
    {
        this.y = y;
    }
    public string ToString()
    {
        return $"{x},{y}";
    }
    public int[] GetXY()
    {
        var arr = new int[] { x, y };
        return arr;
    }
    public void SetXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public double Distance(int x, int y)
    {
        return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
    }
    public double Distance(Point another)
    {
        return Math.Sqrt(Math.Pow(this.x - another.x, 2) + Math.Pow(this.y - another.y, 2));
    }
    public double Distance()
    {
        return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
    }
}
