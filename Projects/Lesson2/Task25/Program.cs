using System;

class Program
{
    static uint Fib(uint n)
    {
        uint a0 = 0;
        uint a1 = 1;
        uint a = a1;
        for (int i = 2; i <= n; i++)
        {
            a = a0 + a1;
            a0 = a1;
            a1 = a;
        }
        return a1;
    }

    //static uint Fib(uint n)
    //{
    //    if (n == 0) return 0;
    //    if (n == 1) return 1;
    //    return Fib(n - 1) + Fib(n - 2);
    //}

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        uint n = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }
}