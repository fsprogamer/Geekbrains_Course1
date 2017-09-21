using System;

class Program
{

    static void Move(int number, int from, int to, int free)
    {
        if (number > 0)
        {
            Move(number - 1, from, free, to);
            Console.WriteLine("{0} => {1}", from, to);
            Move(number - 1, free, to, from);
        }
    }

    static void Main(string[] args)
    {
        Move(4, 1, 2, 3);
    }
}
