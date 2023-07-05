namespace Classes;

public class BirdsCount1
{
    List<int> _birdCounts;
    public BirdsCount1(List<int> birdCounts){
        _birdCounts = birdCounts;
    }
    public int IncrementTodaysCount(){
    return _birdCounts[_birdCounts.Count-1]++;
    }
    public int Today(){
    return _birdCounts[_birdCounts.Count-1];
    }
}