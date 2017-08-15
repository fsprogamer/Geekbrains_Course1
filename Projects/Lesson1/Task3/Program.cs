using System;

class Program
{
    static int Sqr(int x)
    {
        return x * x;
    }
    static void Main(string[] args)
    {
        int value = 8;
        Console.WriteLine("Квадрат числа " + value + " = " + Sqr(value));
    }
}


