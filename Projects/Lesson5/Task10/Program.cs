//using System;
//class StringAppend
//{
//    const int iIterations = 10000;
//    public static void Main()
//    {
//        DateTime dt = DateTime.Now;
//        string str = String.Empty;
//        for (int i = 0; i < iIterations; i++)
//            str += "abcdefghijklmnopqrstuvwxyz\r\n";
//        Console.WriteLine(DateTime.Now - dt);
//    }
//}

using System;
using System.Text;
class StringBuilderAppend
{
    const int iIterations = 10000;
    public static void Main()
    {
        DateTime dt = DateTime.Now;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iIterations; i++)
            sb.Append("abcdefghijklmnopqrstuvwxyz\r\n");
        string str = sb.ToString();
        Console.WriteLine(DateTime.Now - dt);
    }
}
