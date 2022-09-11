using System;
class BaseShip
{
    public int Males { get; protected set; }
}
class Submarine:BaseShip
{
    public Submarine(int n)
    {
        Males = n;
    }
}
class Cruiser:BaseShip
{
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
        BaseShip[] list = { new Submarine(30), new Cruiser(10, 20) };
        int sum = 0;
        foreach (dynamic item in list)
        {
            sum += item.Females;
        }
        Console.WriteLine("Males in ship are " + sum);
    }
}