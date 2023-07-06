namespace Task.IVehicle;

public class Car : IVehicle
{
    public int Speed { get; set; }
    public bool IsRunning(bool run)
    {
        if (run)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Start()
    {
        System.Console.WriteLine("Starting car engine."); ;
    }

    public void Stop()
    {
        System.Console.WriteLine("Stopping car engine."); ;
    }
    public void Drive()
    {
        System.Console.WriteLine($"Driving at {Speed} mph");
    }
}
