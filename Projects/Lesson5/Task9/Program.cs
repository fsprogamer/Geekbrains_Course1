using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder a = new StringBuilder("2*3=3*2");
        Console.WriteLine(a);
        int k = 0;
        for (int i = 0; i < a.Length; ++i)
            if (char.IsDigit(a[i]))
                k += int.Parse(a[i].ToString());
        Console.WriteLine(k);
    }
}
