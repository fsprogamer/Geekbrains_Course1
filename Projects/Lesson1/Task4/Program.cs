using System;

class Program
{
    static void Pause()             // Создали метод
    {
        Console.ReadKey();
    }
    static void Pause(string msg)   // Перегрузили метод
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        Pause("Перегруженный метод");
    }
}
