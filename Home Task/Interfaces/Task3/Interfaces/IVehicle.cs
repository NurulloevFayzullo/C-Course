namespace Task3.Interfaces;

public interface IVehicle
{
    int Amount { get; set; }
    void Drive();
    bool Refual(int refual);
}
