
namespace Task.Technology;

public class Smartphone : Computer
{
  int numberOfSelfies;

  public Smartphone(int ram,int storage,string keyboard) : base (ram,storage,keyboard)
  {
    
  }
  public int TakeSelfies(){
   return numberOfSelfies++;
  } 
  public void ShowSelfies(){
    System.Console.WriteLine(numberOfSelfies);
  }
}
