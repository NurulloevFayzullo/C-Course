using System.Runtime.Intrinsics.Arm.Arm64;
namespace Task3.Interfaces;

public class Car : IVehicle
{
    public int Amount { get; set; }
    public Car()
    {
    Amount=0;
    }
    public void Drive()
    {
        if (Amount > 0)
        {
            System.Console.WriteLine("Driving");
        }
        else
        {
            System.Console.WriteLine("You have to refueling your car");
        }
    }

    public bool Refual(int refual)
    {
        Amount += refual;
        return true;
    }
}
