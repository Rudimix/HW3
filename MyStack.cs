using System;
using System.Collections.Generic;

public class MyStack
{
    private List<int> list;

    public MyStack()
    {
        list = new List<int>();
    }

    public int Count
    {
        get { return list.Count; }
    }

    public void Push(int item)
    {
        list.Add(item);
    }

    public int Pop()
    {
        int item = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return item;
    }

    public int Back()
    {
        return list[list.Count - 1];
    }

    public void Clear()
    {
        list.Clear();
    }

    public void PrintStack()
    {
        foreach (var elem in list)
        {
            Console.Write($"{elem} ");
        }
        Console.WriteLine();
    }
}
