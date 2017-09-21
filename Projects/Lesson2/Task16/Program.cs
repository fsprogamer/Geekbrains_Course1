using System;

class Program
{
    static void Main(string[] args)
    {
        Loop(3, 13);
    }

    static void Loop(int a, int b)
    {
        Console.Write("{0,4} ", a);
        if (a < b) Loop(a + 1, b);
    }

}
