using System;

class Program
{
    static bool Odd(int n)
    {
        return n % 2 == 0;
    }
    static void Main(string[] args)
    {
        int value = 100500;
        Console.WriteLine(Odd(value));
    }
}

