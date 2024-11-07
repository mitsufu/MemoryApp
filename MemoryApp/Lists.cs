using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListTests
{
    public void Capacity()
    {
        var l = new List<int>();

        l.Add(1);
        l.Add(2);
        l.Add(3);
        l.Add(4);
        l.Add(5);
        l.Add(6);
    }
    public void Add()
    {
        var l = new List<Item>(100_000);
        for (int i = 0; i < 100_000; i++)
            l.Add(new Item());
    }
    public void Insert()
    {
        var sw = Stopwatch.StartNew();

        var l = new List<Item>();
        for (int i = 0; i < 200_000; i++)
            l.Insert(0, new Item());
        sw.Stop();

        Console.WriteLine(sw.Elapsed);
    }
    public void LinkedList()
    {
        var sw = Stopwatch.StartNew();

        var l = new LinkedList<Item>();
        for (int i = 0; i < 200_000; i++)
            l.AddLast(new Item());
        sw.Stop();

        Console.WriteLine(sw.Elapsed);
    }
    }
public class Item
{
    long x;
}

public class CircularArray<T>
{
    private T[] _array;
    private int _head;
    private int _count;

    public CircularArray(int size)
    {
        if (size <= 0)
            throw new ArgumentOutOfRangeException(nameof(size), "Size must be greater than zero.");

        _array = new T[size];
        _head = 0;
        _count = 0;
    }

    public void Add(T item)
    {
        _array[(_head + _count) % _array.Length] = item;
        if (_count < _array.Length)
        {
            _count++;
        }
        else
        {
            _head = (_head + 1) % _array.Length; // Déplace le head si le tableau est plein
        }
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

        return _array[(_head + index) % _array.Length];
    }

    public int Count => _count;

    public void Clear()
    {
        _head = 0;
        _count = 0;
        _array = new T[_array.Length]; // Réinitialise le tableau
    }
}


//Span<int> i = stackalloc int[100];
