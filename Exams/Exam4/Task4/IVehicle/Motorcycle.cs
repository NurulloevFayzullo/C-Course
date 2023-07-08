namespace Task4.IVehicle;

public class Motorcycle : IVehicle
{
    public int Speed {get; set;}
    public bool IsRunning(int run)
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
       System.Console.WriteLine("Starting motorcycle engine.");
    }

    public void Stop()
    {
       System.Console.WriteLine("Stopping motorcycle engine.");
    }
     public void Drive(){
        System.Console.WriteLine($"« Driving at {Speed} mph");
    }
}
