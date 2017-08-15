﻿using System;

class Program
{
    static void Main()
    {
        try
        {
            char b = 'B', c = '\x64', d = '\uffff';
            Console.WriteLine("{0}, {1}, {2}", b, c, d);
            Console.WriteLine("{0}, {1}, {2}", char.ToLower(b), char.ToUpper(c), char.GetNumericValue(d));
            char a;
            do  // цикл выполняется до тех пор, пока не ввели символ e
            {
                Console.WriteLine("Введите символ: ");
                a = char.Parse(Console.ReadLine());
                Console.WriteLine("Введен символ {0}, его код  {1}, его категория {2}", a, (int)a, char.GetUnicodeCategory(a));
                if (char.IsLetter(a)) Console.WriteLine("Буква");
                if (char.IsUpper(a)) Console.WriteLine("Верхний регистр");
                if (char.IsLower(a)) Console.WriteLine("Нижний регистр");
                if (char.IsControl(a)) Console.WriteLine("Управляющий символ");
                if (char.IsNumber(a)) Console.WriteLine("Число");
                if (char.IsPunctuation(a)) Console.WriteLine("Разделитель");
            } while (a != 'e');
        }
        catch
        {
            Console.WriteLine("Возникло исключение");
        }
    }
}


