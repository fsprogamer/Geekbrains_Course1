using System;
class Program
{
    static void Main(string[] args)
    {
        bool flag;           // Использование логической переменной в качестве "флага"
        do
        {
            Console.WriteLine("Введите число:");
            try
            {
                flag = false;// Флаг опущен
                int a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неверный формат данных");
                Console.WriteLine(ex.Message);
                flag = true; // Ошибка - подняли флаг
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неправильно ввели данные");
                Console.WriteLine(ex.Message);
                flag = true; // Ошибка - подняли флаг
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
        while (flag);       // Повторяем, пока флаг поднят
    }
}
