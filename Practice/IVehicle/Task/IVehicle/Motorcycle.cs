namespace Task.IVehicle;

public class Motorcycle : IVehicle
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
        System.Console.WriteLine("Starting motorcycle engine.");
    }

    public void Stop()
    {
        System.Console.WriteLine("Stopping motorcycle engine.");
    }
    public void Drive()
    {
        System.Console.WriteLine($"Driving at {Speed} mph");
    }
}
