namespace Task4.IVehicle;

public class Car : IVehicle
{
    public int Speed {get; set;}
    public bool IsRunning(int run)
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        System.Console.WriteLine("Starting car engine.");
    }

    public void Stop()
    {
        System.Console.WriteLine("Stopping car engine.");
    }
    public void Drive(){
        System.Console.WriteLine($"« Driving at {Speed} mph");
    }
    }
