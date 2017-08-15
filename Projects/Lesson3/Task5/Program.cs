using System;
using System.Threading;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine(start);
            Thread.Sleep(2000);
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish);
            TimeSpan duration = finish - start;            
            Console.WriteLine(duration);
        }
    }
}
