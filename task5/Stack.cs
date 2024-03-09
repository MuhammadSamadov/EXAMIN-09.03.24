using System.Diagnostics;

namespace task5;

public class Stack<T>
{
    T? nums;
    List<T> list = new List<T>();
    public void Push(T item)
    {
        list.Add(item);
    }
    public void Pop()
    {

    }
    public void Peek()
    {

    }

}
