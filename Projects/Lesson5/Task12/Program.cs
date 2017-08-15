﻿using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        StringBuilder a = new StringBuilder(Console.ReadLine());
        Console.WriteLine("Исходная строка: " + a);
        for (int i = 0; i < a.Length;)
            if (char.IsPunctuation(a[i])) a.Remove(i, 1);
            else ++i;
        string str = a.ToString();
        string[] s = str.Split(' ');
        Console.WriteLine("Искомые слова: ");
        for (int i = 0; i < s.Length; ++i)
            if (s[i][0] == s[i][s[i].Length - 1]) Console.WriteLine(s[i]);
    }
}


