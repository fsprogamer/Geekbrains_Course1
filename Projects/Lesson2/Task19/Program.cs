using System;

class Program
{
    static int NOD(int a, int b)
    {
        while (a != b)
            if (a > b) a = a - b; else b = b - a;
        return a;
    }

    static void Main()
    {
        int a = 532;
        int b = 224;
        Console.WriteLine(NOD(a, b));
    }
}