using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 1;
        double b = 1;
        double c = 1;
        double x;
        Console.Write("Введите значение x: ");
        string s = Console.ReadLine();
        x = Convert.ToDouble(s);
        double f = a * Math.Pow(x, 2) + b * x + c;
        Console.WriteLine("{0}*x^2+{1}*x+{2}, при x={3}, f={4}", a, b, c, x, f);
        Console.ReadLine();
    }
}


