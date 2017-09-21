using System;

class Program
{
    static void Main(string[] args)
    {
        //Внешний цикл
        for (int i = 0; i < 80; i++)
            //Внутренний цикл
            for (int j = 0; j < 24; j++)
            {
                Console.SetCursorPosition(i, j);         // устанавливаем позицию курсора
                Console.Write('*');
                System.Threading.Thread.Sleep(20);// делаем паузу
                Console.Title = "i=" + i + " j=" + j;
            }
        Console.ReadKey();
    }
}