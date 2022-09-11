using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    class countDownWrapper
    {
        public AutoResetEvent Done = new AutoResetEvent(false);
        private int count = 9;
        public void CountDown()
        {
            Console.WriteLine(count--);
            if (count >= 0)
            {
                Task.Delay(1000).ContinueWith((c) => { CountDown(); });
            }
            else
            {
                Done.Set();
            }
        }
    }
    static void Main(string[] args)
    {
        var a = new countDownWrapper();
        var b = new countDownWrapper();
        a.CountDown();
        b.CountDown();
        AutoResetEvent.WaitAll(new[] { a.Done, b.Done });
    }
}
