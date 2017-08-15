using System;
using System.Text.RegularExpressions;
using System.IO;
// Пример сканирования папки C:\Temp на поиск всех адресов e-mail
namespace MailScan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем список файлов в папке. AllDirectories - сканировать так же и подпапки
            string[] fs = Directory.GetFiles("f:\\Books", " *.*", SearchOption.AllDirectories);
            // Просматриваем каждый файл в массиве
            foreach (var filename in fs)
            {
                // Создаем регулярное выражения дя поиска почтовых адресов
                Regex regex = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");
                // Считываем файл
                string s = File.ReadAllText(filename);
                Console.WriteLine(filename);
                // Выводим найденые адреса на экран
                foreach (var c in regex.Matches(s))
                    Console.Write("{0} ", c);
            }
            Console.ReadKey();
        }
    }
}

