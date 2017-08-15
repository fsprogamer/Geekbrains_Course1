using System;
class Program
{
    static void Main()
    {
        int[] a = new int[10];
        int i;
        for (i = 0; i < 10; i++) a[i] = i * i;
        for (i = 0; i < 10; i++) Console.WriteLine(a[i]);
        Console.WriteLine();
    }
}

