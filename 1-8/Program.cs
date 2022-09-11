using System;
using System.Linq;
using System.Collections.Generic;

class SimpleSum
{
    private int[] array;
    private int sum;
    
    private void calc()
    {
        sum = array.Sum();
    }
    public SimpleSum(int max)
    {
        array = Enumerable.Range(0,max).ToArray();
        calc();
        array = null;
    }
}
class Program
{
    static void Main(string[] args)
    {
        var list = new List<SimpleSum>();
        for (int i= 0; i < 1000000; i++)
        {
            list.Add(new SimpleSum(10000));
        }
        Console.WriteLine("the End");
    }
}