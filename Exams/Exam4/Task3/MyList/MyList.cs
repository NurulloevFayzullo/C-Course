
namespace Task3.MyList;

public class MyList<T>
{
    List<T> list;
    public MyList()
    {
        list = new List<T>();
    }
    public void Add(T elem)
    {
        list.Add(elem);
    }
    public void Remove(T elem)
    {
        list.Remove(elem);
    }
    public int Count()
    {
        return list.Count;
    }
    public bool Contains(T type)
    {
        foreach (var item in list)
        {
            if (item == type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public string ToString()
    {
        return list.Join(",");
    }

}
