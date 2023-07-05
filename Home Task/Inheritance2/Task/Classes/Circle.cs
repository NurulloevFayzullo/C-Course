namespace Task.Classes;

public class Circle
{
    double radius = 1.0;
    string color = "red";
    protected const double pi=3.14;
    public Circle()
    {

    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }
   public double GetRadius(){
    return radius;
   }
   public void SetRadius(double radius){
    this.radius = radius;
   }
   public string GetColor(){
    return color;
   }
   public void SetColor(string color){
    this.color = color;
   }
   public string toString(){
    return base.ToString();
   }
   public double GetArea(){
    return pi*radius*radius;
   }
}
