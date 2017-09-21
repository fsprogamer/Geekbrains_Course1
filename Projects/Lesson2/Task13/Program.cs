using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "Hello, Foreach";
        foreach (char c in s)
            Console.Write("{0} ", c);
    }
}
