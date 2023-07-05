namespace Classes;
public class BirdsCount2
{
    List<int> _birdsCount;
    public BirdsCount2(List<int> birdCounts){
        _birdsCount = birdCounts;
    }
    public void HasDayWithoutBirds(){
        foreach (var bird in _birdsCount)
        {
            if (bird == 0)
            {
               System.Console.WriteLine(true);
               break;
            }
            
        }
    }

}