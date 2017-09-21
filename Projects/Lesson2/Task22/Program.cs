using System;

class Program
{
    static void Main()
    {
        int k = 0, s = 0;
        Console.WriteLine("Введите число:");
        int a = int.Parse(Console.ReadLine());
        while (a != 0)
        {
            if (a > 0 && a % 8 == 0) { k++; s = s + a; }
            a = int.Parse(Console.ReadLine());
        }
        Console.WriteLine((double)s / k);
    }
}
