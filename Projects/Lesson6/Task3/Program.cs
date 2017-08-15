using System;
using System.Text.RegularExpressions;
using System.IO;
// Поиск всех чисел в файле
namespace StreamReader_RegularExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileIn = new StreamReader("hobbit.txt");
            StreamWriter fileOut = new StreamWriter("numbers.txt", false);
            string text = fileIn.ReadToEnd();
            Regex r = new Regex(@"[-+]?\d+");
            Match integer = r.Match(text);
            while (integer.Success)
            {
                Console.WriteLine(integer);
                fileOut.WriteLine(integer);
                integer = integer.NextMatch();
            }
            fileIn.Close();
            fileOut.Close();
            Console.ReadKey();
        }
    }
}

