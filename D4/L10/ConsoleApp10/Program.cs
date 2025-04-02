using System;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> _items = new List<T>();

    public void Add(T i)
    {
        _items.Add(i);
    }

    public T this[int i]
    {
        get { return _items[i]; }
    }

    public int Count
    {
        get { return _items.Count; }
    }
}

public static class Extension
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(9);
        myList.Add(3);
        myList.Add(10);

        int[] array = myList.GetArray();

        Console.WriteLine("Элементы массива:");
        foreach (var i in array)
        {
            Console.WriteLine(i);
        }
    }
}
