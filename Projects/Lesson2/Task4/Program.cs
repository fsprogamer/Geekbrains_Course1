using System;

class Program
{
    static bool Odd(int a)
    {
        return a % 2 == 0;
    }
    static void Main(string[] args)
    {
        int x;
        Console.WriteLine("Введите целое число.");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x + " - " + ((Odd(x)) ? "четное число" : "нечетное число"));
        Console.WriteLine("Для выхода из приложение нажмите Enter");
        Console.ReadLine();
    }
}