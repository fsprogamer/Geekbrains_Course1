using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(1303));
    }
    static long Sum(long a)// нерекурсивный метод
    {
        long s = 0;
        while (a > 0)                // пока a больше нуля
        {
            s = s + a % 10;             // добавляем к сумме последнюю цифру числа а
            a = a / 10;             // отбрасываем от числа а последнюю цифру
        }
        return s;                   // возвращаем в качестве результата сумму цифр числа a
    }

    //static long RecursiveSum(long a)              // рекурсивный метод
    //{
    //    if (a == 0)                                          // если a =0, то
    //        return 0;                                          // возвращаем 0
    //    else return RecursiveSum(a / 10) + a % 10; // иначе, вызываем рекурсивно сами себя
    //}
}