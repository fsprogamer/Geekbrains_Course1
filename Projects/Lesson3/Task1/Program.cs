using System;

namespace Task1
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a={0} b={1}", a, b);
            Swap(ref a, ref b);// Пример вызова
            Console.WriteLine("a={0} b={1}", a, b);
        }
    }
}
