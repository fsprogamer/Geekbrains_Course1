using System;

//namespace Task9
//{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++) Console.Write("[{0,5}]", rnd.Next(0, 10));
            Console.WriteLine();
        }
    }
//}
