using System;
using System.IO; // Обязательно еще одно пространство имен.

class Program
{
    static void Main()
    {
        // Создаем объект sr и связываем его с файлом data.txt.
        StreamReader sr = new StreamReader("..\\..\\data.txt");
        // Считаем количество чисел.
        int n = int.Parse(sr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(sr.ReadLine());
            Console.WriteLine(a);
        }
        // Освобождаем файл data.txt для использования другими программами.
        sr.Close();
    }
}

