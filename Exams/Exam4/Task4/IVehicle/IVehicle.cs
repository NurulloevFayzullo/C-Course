namespace Task4.IVehicle;

public interface IVehicle
{
    int Speed { get; set; }
    void Start();
    void Stop();
    bool IsRunning(int run);
    void Drive();
}
