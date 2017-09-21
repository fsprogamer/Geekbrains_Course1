using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "1. Привет, Foreach. \n2. А так же break и continue! А это не выведется";
        foreach (char c in s)
        {
            // Пропускаем цифры
            if (c >= '0' && c <= '9') continue;
            // Если встречаем ! прерываем цикл
            if (c == '!') break;
            Console.Write("{0} ", c);
        }
    }
}