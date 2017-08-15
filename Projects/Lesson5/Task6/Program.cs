using System;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hello!";
        string s2 = "Hello!";
        // сравнение с использованием статического метода
        Console.WriteLine(String.Compare(s1, s2));
        // сравнение с использованием не статического метода
        Console.WriteLine(s1.CompareTo(s2));
    }
}


