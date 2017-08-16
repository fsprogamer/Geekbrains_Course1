using System;

class Program
{
    static void Main()
    {
        // Используется для получения объекта System.Type для типа.
        // Выражение typeof принимает следующую форму:
        Type type = typeof(int);
        Console.WriteLine(type);
        // Для получения типа выражения во время выполнения можно 
        // воспользоваться методом платформы.NET GetType, как показано в следующем примере:
        int i = 0;
        Type type2 = i.GetType();
        Console.WriteLine(type2);
    }
}
