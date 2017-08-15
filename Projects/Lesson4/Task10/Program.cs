using System;
using System.IO;

namespace ReadFromFileWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("..\\..\\data.txt");
            int sum = 0, count = 0;
            while (!sr.EndOfStream)  // Пока не конец потока (файла)
            {
                string s = sr.ReadLine();
                Console.WriteLine("Считали строку:" + s);
                try
                {
                    int a = int.Parse(s);
                    sum = sum + a;
                    count++;
                    Console.WriteLine("{0}.Преобразовали в число:{1}", count, a);
                }
                // В экземпляре exc класса Exception будет
                // храниться информация об ошибке.
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            sr.Close();
            Console.WriteLine("Среднее арифметическое:{0:f2}", (double)sum / count);
            // Обратите внимание! Если не поставить явное приобразование типов перед sum, то sum/count получит целое число. Попробуйте убрать (double) перед sum.
        }
    }
}

