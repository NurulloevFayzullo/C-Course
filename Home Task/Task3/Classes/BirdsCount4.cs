namespace Classes;

public class BirdsCount4
{
    List<int> _birdsCount4;
    public BirdsCount4(List<int> birdsCount4){
        _birdsCount4 = birdsCount4;
    }
    public int BusyDays(){
        int count=0;
        foreach (var bird in _birdsCount4)
        {
            if (bird >= 5)
            {
               count++;
            }
        }
        return count;
    }
}