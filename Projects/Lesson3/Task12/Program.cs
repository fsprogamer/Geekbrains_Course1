using System;

namespace Task12
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int d = 3;
            // a/d
            int r = a, q = 0;
            while (r >= d)
            {
                r = r - d;
                q++;
            }
            Console.WriteLine("Частное {0}.\nОстаток {1}", q, r);
        }
    }
}
