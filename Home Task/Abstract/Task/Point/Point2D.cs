namespace Task.Point;

public class Point2D
{
    int x = 0;
    int y = 0;
    
    public Point2D(){}

    public Point2D(int x,int y)
    {
        this.x=x;
        this.y=y;
    }
    public int getX(){
        return x;
    }
    public void setX(int x){
        this.x=x;
    }
    public int getY(){
        return y;
    }
    public void setY(int y){
       this.y=y;
    }
    public virtual string toString(){
        return $"x-{x} y-{y}";
    }
}
