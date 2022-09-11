using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, -1, 2, -2, 3 };
        foreach(var item in array)
        {
            if (item < 0)
            {
                Console.WriteLine(item);
                break;
            }
        }
    }
}
