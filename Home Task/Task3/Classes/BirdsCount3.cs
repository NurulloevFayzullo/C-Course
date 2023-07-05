namespace Classes;

public class BirdsCount3
{
    List<int> _birdsCount3;
    public BirdsCount3(List<int> birdsCount3){
        _birdsCount3=birdsCount3;
    }
       public int CountForFirstDays(){
        int sum=0;
        for (int i = 0; i < _birdsCount3.Count; i++)
        {
            sum+=_birdsCount3[i];
        }
        return sum;
    }
    public int CountForFirstDays(int num){
        int sum=0;
        for (int i = 0; i < num; i++)
        {
            sum+=_birdsCount3[i];
        }
        return sum;
    }
}