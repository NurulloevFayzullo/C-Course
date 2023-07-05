namespace Task.Classes;

public class Cylinder : Circle
{
    double height = 1.0;
    public Cylinder()
    {

    }
    public Cylinder(double height)
    {
        this.height = height;
    }
    public Cylinder(double height, double radius) : base(radius)
    {
        this.height = height;
    }
    public Cylinder(double height, double radius, string color) : base(radius, color)
    {
        this.height = height;
    }
    public double GetHeight()
    {
        return height;
    }
    public void SetHeight(double height){
        this.height = height;
    }
    public double GetVolume(){
        return pi*Math.Pow(base.GetRadius(),2)*height;
    }
}
