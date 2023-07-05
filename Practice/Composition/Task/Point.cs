namespace Task;

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
    public int getX()
    {
        return x;
    }
    public void setX(int x)
    {
        this.x = x;
    }
    public int getY()
    {
        return y;
    }
    public void setY(int y)
    {
        this.y = y;
    }
    public string toString()
    {
        return $"{x},{y}";
    }
    public int[] getXY()
    {
     List<int> arr= new List<int>{};
     
    }
    public void setXY(int x, int y)
    {

    }
}
