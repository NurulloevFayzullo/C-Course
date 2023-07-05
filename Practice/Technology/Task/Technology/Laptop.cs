namespace Task.Technology;

public class Laptop : Computer
{
    double _weight;

   public Laptop(int weight,int ram,int storage,string keyboard) :base(ram,storage,keyboard)
   {
    _weight=weight;
   }
   public bool WeightCheck(){
    if (_weight <3.5)
    {
        return true;
    }
    else{
        return false;
    }
   }
}
