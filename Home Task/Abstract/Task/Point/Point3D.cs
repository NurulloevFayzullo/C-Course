namespace Task.Point;

public class Point3D : Point2D
{
    int z = 0;
    public Point3D() { }
    public Point3D(int x, int y, int z) : base(x,y)
    {
    this.z=z;
    }
    public int getZ(){
        return z;
    }
    public void setZ(int z){
        this.z=z;
    }
    public override string toString(){
    return $"{base.toString()} Z-{z}";
    }
}
