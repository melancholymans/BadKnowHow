using System;
class Submarine
{
    public int Males { get; private set; }
    public Submarine(int n)
    {
        Males = n;
    }
}
class Cruiser
{
    public int Males { get; private set; }
    public int Females { get; private set; }
    public Cruiser(int m,int f)
    {
        Males=m;
        Females=f;
    }
}

class Program
{
    static void Main(string[] args)
    {
        object[] list = { new Submarine(30), new Cruiser(10, 20) };
        int sum = 0;
        foreach (dynamic item in list)
        {
            sum += item.Females;
        }
        Console.WriteLine("Males in ship are " + sum);
    }
}