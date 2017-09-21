using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите меньшее число:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите большее число:");
        int b = int.Parse(Console.ReadLine());
        int k = 0, s = 0;
        for (int i = b; i >= a; i--)
        {
            Console.Write(i + " ");
            k++;
            s = s + i;
        }
        Console.WriteLine("\nk={0} s={1}", k, s);
    }
}