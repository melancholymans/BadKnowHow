using System;
using System.Threading.Tasks;

class Program
{
    private static async Task CountDown()
    {
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(i);
            await Task.Delay(1000);
        }
    }
    static void Main(string[] args)
    {
        var a = CountDown();
        var b = CountDown();
        Task.WaitAll(a, b);
    }
}