namespace Task2.Shape;
public class Rectangle : Shape
{
    protected double side1;
    protected double side2;
    
    public override double Area(){
        return side1*side2;
    }
    public override double Perimeter()
    {
        return 2*(side1+side2);
    }
}