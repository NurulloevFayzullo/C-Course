namespace Task.IVehicle;

public interface IVehicle
{
    int Speed { get; set; }
    void Start();
    void Stop();
    bool IsRunning(bool run);
    void Drive();
}
