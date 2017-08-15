using System;
namespace Static_or_Non_Static
{
    class MyClass
    {
        public static int static_a;
        public int non_static_a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.static_a = 10;
            MyClass myobj = new MyClass();
            myobj.non_static_a = 10;
        }
    }
}
