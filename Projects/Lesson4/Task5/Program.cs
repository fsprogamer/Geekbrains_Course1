using System;

class Program
{
    static void Print(int[] a) // передаем только ссылку на массив
    {
        for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
        Console.WriteLine();
    }
    static void Change(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            if (a[i] < 0) a[i] = -a[i];
    }
    static void Main()
    {
        int[] A = { 0, -1, -2, 3, 4, 5, -6, -7, 8, -9 };
        Print(A);
        Change(A);
        Print(A);
    }
}

