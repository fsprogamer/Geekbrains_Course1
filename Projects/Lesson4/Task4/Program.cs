﻿using System;

class Program
{
    static void Print(int n, int[] a)
    // n–размерность массива, а–ссылка на массив
    {
        for (int i = 0; i < n; i++) Console.Write("{0} ", a[i]);
        Console.WriteLine();
    }
    static void Change(int n, int[] a)
    {
        for (int i = 0; i < n; i++)
            if (a[i] < 0) a[i] = -a[i];
        // изменяются элементы массива 
    }
    static void Main()
    {
        int[] myArray = { 0, -1, -2, 3, 4, 5, -6, -7, 8, -9 };
        Print(10, myArray);
        Change(10, myArray);
        Print(10, myArray);
    }
}
