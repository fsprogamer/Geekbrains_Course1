using System;
using System.IO;
namespace DirectoryInfo2
{
    class Program
    {
        static void printDirect(DirectoryInfo dir)
        {
            Console.WriteLine("***** " + dir.Name + " *****");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes.ToString());
            Console.WriteLine("Root: {0}", dir.Root);
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            printDirect(dir);
            DirectoryInfo[] subDirects = dir.GetDirectories();
            Console.WriteLine("Найдено {0} подкаталогов", subDirects.Length);
            foreach (DirectoryInfo d in subDirects)
            {
                printDirect(d);
            }
        }
    }
}

