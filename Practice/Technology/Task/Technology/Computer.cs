namespace Task.Technology;

abstract public class Computer
{
    int _ram;
    int _storage;
    string _keyboard;
   public Computer(int ram,int storage,string keyboard)
   {
    _ram=ram;
    _storage=storage;
    _keyboard=keyboard;
   }
   public int AddRam(int ram){
    return  _ram+=ram;
   } 
   public int AddStorage(int storage){
   return _storage+=storage;
   }
   public void ToString(){
    System.Console.WriteLine($"Ram-{_ram} Storage-{_storage} Keyboard-{_keyboard}");
   }
}
