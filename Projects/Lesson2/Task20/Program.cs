using System;

class Program
{
    static bool Check(int a)
    {
        if ((a % 10 + a / 10 % 10 == 10)) return true; else return false;
    }

    static void Main(string[] args)
    {
        for (int i = 10; i <= 100; i++)
            if (Check(i)) Console.WriteLine(i);
    }
}