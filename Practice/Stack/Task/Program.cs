


public class Stack<T>
{
    public List<T> stack;
    public Stack()
    {
        stack = new List<T>();
    }
    public void Push(T add)
    {
        stack.Add(add);
    }
}