﻿using System;

namespace Task11
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int max = a;
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max) max = a;
            }
            Console.WriteLine(max);
        }
    }
}
