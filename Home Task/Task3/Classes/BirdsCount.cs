namespace Classes;
public class BirdsCount
{
    List<int> _birdsCount;

    public BirdsCount(List<int> birdsCount){
        _birdsCount = birdsCount;
    }
    public int Today(){
      return _birdsCount[_birdsCount.Count-1];
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////
