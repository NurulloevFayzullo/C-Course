namespace Task2.Vehicle;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
     
     public Car(string make,string model,int year,int y,int numberOfDoors) : base(make,model,year)
    {
        NumberOfDoors=numberOfDoors;
    }
} 
