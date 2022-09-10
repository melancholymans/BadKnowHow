using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var heavyQuery = Enumerable.Range(0, 10).Where(c =>
        {
            Task.Delay(1000).Wait();
            return true;
        });
        var start=DateTime.Now;
        for(int i = 0; i < heavyQuery.Count(); i++)
        {
            Console.WriteLine(heavyQuery.ElementAt(i));
        }
        Console.WriteLine("所要時間: {0}",DateTime.Now-start);
    }
}
