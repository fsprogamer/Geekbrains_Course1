using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        const int DAYS = 8;                   // Кол-во дней в 2008 г.
        double[] tMonth = new double[12];// Массив для хранения температур по месяцам
        int i, month;
        double t, tYear = 0;                               // Температура за год
        StreamReader sr = new StreamReader("..\\..\\data.txt");
        for (i = 0; i < DAYS; i++)                       // Считывам файл с датами и температурами
        {
            // Считываем строчку с данными за день и заменяем в строке . на ,    
            string s = sr.ReadLine().Replace('.', ',');
            // Разбиваем строку по пробелу   
            string[] ss = s.Split(new char[] { ' ' });
            // Получаем месяц. И уменьшаем месяц на единицу(у нас массив с месяцами с 0, а номера месяцев с 1)                                        
            month = int.Parse(ss[0].Substring(3)) - 1;
            t = double.Parse(ss[1]);                   // Получаем температуру в этот день               
            tMonth[month] = tMonth[month] + t;// Подсчитываем температуру в месяце                                     
            tYear = tYear + t;                             // Суммируем температуры в году
        }
        sr.Close();
        for (i = 0; i < 12; i++)                            // Получаем среднюю температуру в месяце
            switch (i)
            {
                case 1:
                    tMonth[i] = tMonth[i] / 29;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    tMonth[i] = tMonth[i] / 30;
                    break;
                default:
                    tMonth[i] = tMonth[i] / 31;
                    break;
            }
        tYear = tYear / DAYS;                                 // Получаем среднюю температуру за год
        double min = Math.Abs(tMonth[0] - tYear);// Принимаем начальное минимальное значение                                     
        for (i = 0; i < 12; i++)                                  // Находим минимальное значение
            if (Math.Abs(tMonth[i] - tYear) < min)
                min = Math.Abs(tMonth[i] - tYear);
        // Все месяцы среднее отклонение температуры равно min выводим на экран
        Console.WriteLine("{0:F2}", tYear);
        for (i = 0; i < 12; i++)
            if (Math.Abs(tMonth[i] - tYear) == min) Console.WriteLine("{0} {1:F2} {2:F2}", i, tMonth[i], tMonth[i] - tYear);
    }
}

