namespace Task2.Shape;
public class Shape
{
    public const double p = 3.14;
    public string ToString(){
        return base.ToString();
    }
    public virtual double Area(){
     return 0;
    }
    public virtual double Perimeter(){
    return 1;
    }
}