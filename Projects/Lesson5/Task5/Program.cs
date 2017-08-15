using System;

class Program
{
    static void Main()
    {
        string poems = "белеет парус одинокий в тумане моря голубом";
        char[] div = { ' ' }; // создаем массив разделителей
                              // разбиваем строку на части,
        string[] parts = poems.Split(div);
        Console.WriteLine("Результат разбиения строки на части: ");
        for (int i = 0; i < parts.Length; i++)
            Console.WriteLine(parts[i]);
        // собираем эти части в одну строку, в качестве разделителя используем символ |
        string str = String.Join("|", parts);
        Console.WriteLine("Результат сборки: ");
        Console.WriteLine(str);
    }
}


