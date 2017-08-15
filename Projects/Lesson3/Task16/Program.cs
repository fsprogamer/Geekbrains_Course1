using System;

namespace Points
{
    class Program
    {
        struct Point
        {
            double _x, _y;

            public Point(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public double Distance(Point Z)
            {
                return Math.Sqrt(Math.Pow(_x - Z._x, 2) + Math.Pow(_y - Z._y, 2));
            }
        }

        static void Main(string[] args)
        {
            Point C;

            Point A = new Point(0, 0);
            Point B = new Point(2, 2);
            Console.WriteLine(A.Distance(B));
        }
    }
}
