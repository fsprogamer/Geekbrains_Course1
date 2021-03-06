﻿using System;

class Program
{
    static int NumberSumm(int n)
    {
        int s = 0;
        while (n != 0)
        {
            s = s + n % 10;
            n = n / 10;
        }
        return s;
    }

    static bool isOdd(int n)
    {
        return n % 2 == 0;
    }

    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            int sc = NumberSumm(i);
            if (isOdd(sc)) Console.WriteLine("{0} {1}", i, sc);
        }
    }
}