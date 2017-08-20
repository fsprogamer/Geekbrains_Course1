//using System;

//class Program
//{
//    static void Main()
//    {
//        int a, b, max;
//        Console.WriteLine("Введите два целых числа.");
//        Console.Write("Первое число:");
//        a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Второе число:");
//        b = Convert.ToInt32(Console.ReadLine());
//        if (a > b)
//        {
//            max = a;
//        }
//        else
//        {
//            max = b;
//        };
//        Console.WriteLine("Наибольшее число {0}", max);
//        Console.WriteLine("Для выхода из приложение нажмите Enter");
//        Console.ReadLine();
//    }
//}

using System;

class Program
{
	static void Main()
	{
		int a, b, max;
		Console.WriteLine("Введите два целых числа.");
		Console.Write("Первое число:");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Второе число:");
		b = Convert.ToInt32(Console.ReadLine());
		max = a;
		if (b > max)
			max = b;
		Console.WriteLine("Наибольшее число {0}", max);
		Console.WriteLine("Для выхода из приложение нажмите Enter");
		Console.ReadLine();
	}
}



//using System;

//namespace Lesson2_002
//{
//    class Program
//    {
//        static void Main()
//        {
//            int a, b, max;
//            Console.WriteLine("Введите два целых числа.");
//            Console.Write("Первое число:");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Второе число:");
//            b = Convert.ToInt32(Console.ReadLine());
//            if (a > b)
//            {
//                max = a;
//            }
//            else
//            {
//                max = b;
//            };
//            Console.WriteLine("Наибольшее число {0}", max);
//            Console.WriteLine("Для выхода из приложение нажмите Enter");
//            Console.ReadLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static bool Odd(int a)
//    {
//      return a%2==0;
//    }
//    static void Main(string[] args)
//    {
//     int x;
//     Console.WriteLine("Введите целое число.");
//     x = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(x + " - " + ((Odd(x)) ? "четное число" : "нечетное число"));
//     Console.WriteLine("Для выхода из приложение нажмите Enter");
//     Console.ReadLine();
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        int x;
//        Console.WriteLine("Введите целое число.");
//        x = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine(x + " - " + ((x % 2 == 0) ? "четное число" : "нечетное число"));
//        Console.WriteLine("Для выхода из приложение нажмите Enter");
//        Console.ReadLine();
//    }
//}


//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int caseSwitch = 1;
//        switch (caseSwitch)
//        {
//            case 1:
//                Console.WriteLine("Case 1");
//                break;
//            case 2:
//                Console.WriteLine("Case 2");
//                break;
//            default:
//                Console.WriteLine("Default case");
//                break;
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {

//        int m = 6;
//        string s;
//        switch (m)
//        {
//            case 1:
//            case 2:
//            case 12: s = "Зима";
//                break;
//            case 3:
//            case 4:
//            case 5: s = "Весна";
//                break;
//            case 6:
//            case 7:
//            case 8: s = "Лето";
//                break;
//            case 9:
//            case 10:
//            case 11: s = "Осень";
//                break;
//            default:
//                s = "Ничего";
//                break;
//        }
//        Console.WriteLine(s);
//    }
//}


//using System;

//class Program
//{
//    enum Months { None, January, February, March, April, May, June, July, August, September, October, November, December };
//    enum Seasons { None, Winter, Spring, Summer, Autumn };

//    static void Main(string[] args)
//    {
//        Months month = Months.January;
//        Seasons season = Seasons.None;
//        switch (month)
//        {
//            case Months.January:
//            case Months.February:
//            case Months.December: season = Seasons.Winter;
//                break;
//            case Months.March:
//            case Months.April:
//            case Months.May: season = Seasons.Spring;
//                break;
//            case Months.June:
//            case Months.July:
//            case Months.August: season = Seasons.Summer;
//                break;
//            case Months.September:
//            case Months.October:
//            case Months.November: season = Seasons.Autumn;
//                break;
//        }
//        Console.WriteLine(season);
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        int count = 0;

//        while (n != 0)
//        {
//            count++;
//            n = n / 10;// так как n-целое, деление целочисленное	
//        }
//        Console.WriteLine(count);
//    }
//}




//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int a, count = 0;
//        do
//        {
//            Console.Write("Введите возраст:");
//            a = int.Parse(Console.ReadLine());
//            count++;
//        }
//        while (a < 1 || a > 99);// Повторять пока условие истинно(true)
//        Console.WriteLine("Вы сделали " + count + " попыток ввода");
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write(i + " ");
//            Console.WriteLine("Привет");
//        }
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите меньшее число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите большее число:");
//        int b = int.Parse(Console.ReadLine());
//        int k = 0, s = 0;
//        for (int i = b; i >= a; i--)
//        {
//            Console.Write(i + " ");
//            k++;
//            s = s + i;
//        }
//        Console.WriteLine("\nk={0} s={1}", k, s);
//    }
//}


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string s = "Hello, Foreach";
//        foreach (char c in s)
//            Console.Write("{0} ", c);
//    }
//}


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string s = "1. Привет, Foreach. \n2. А так же break и continue! А это не выведется";
//        foreach (char c in s)
//        {
//            // Пропускаем цифры
//            if (c >= '0' && c <= '9') continue;
//            // Если встречаем ! прерываем цикл
//            if (c == '!') break;
//            Console.Write("{0} ", c);
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        //Внешний цикл
//        for (int i = 0; i < 80; i++)
//            //Внутренний цикл
//            for (int j = 0; j < 24; j++)
//            {
//                Console.SetCursorPosition(i, j);         // устанавливаем позицию курсора
//                Console.Write('*');
//                System.Threading.Thread.Sleep(20);// делаем паузу
//                Console.Title = "i=" + i + " j=" + j;
//            }
//        Console.ReadKey();
//    }
//}


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Loop(3, 13);
//    }

//    static void Loop(int a, int b)
//    {
//        Console.Write("{0,4} ", a);
//        if (a < b) Loop(a + 1, b);
//    }

//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(Sum(1303));
//    }
//    static long Sum(long a)// нерекурсивный метод
//    {
//        long s = 0;
//        while (a > 0)                // пока a больше нуля
//        {
//            s = s + a % 10;             // добавляем к сумме последнюю цифру числа а
//            a = a / 10;             // отбрасываем от числа а последнюю цифру
//        }
//        return s;                   // возвращаем в качестве результата сумму цифр числа a
//    }

//    //static long RecursiveSum(long a)              // рекурсивный метод
//    //{
//    //    if (a == 0)                                          // если a =0, то
//    //        return 0;                                          // возвращаем 0
//    //    else return RecursiveSum(a / 10) + a % 10; // иначе, вызываем рекурсивно сами себя
//    //}
//}


//using System;

//class Program
//{
//    static int NumberSumm(int n)
//    {
//        int s = 0;
//        while (n != 0)
//        {
//            s = s + n % 10;
//            n = n / 10;
//        }
//        return s;
//    }

//    static bool isOdd(int n)
//    {
//        return n % 2 == 0;
//    }

//    static void Main()
//    {
//        for (int i = 1; i <= 100; i++)
//        {
//            int sc = NumberSumm(i);
//            if (isOdd(sc)) Console.WriteLine("{0} {1}", i, sc);
//        }
//    }
//}


//using System;

//class Program
//{
//    static int NOD(int a, int b)
//    {
//        while (a != b)
//            if (a > b) a = a - b; else b = b - a;
//        return a;
//    }

//    static void Main()
//    {
//        int a = 532;
//        int b = 224;
//        Console.WriteLine(NOD(a, b));
//    }
//}


//using System;

//class Program
//{
//    static bool Check(int a)
//    {
//        if ((a % 10 + a / 10 % 10 == 10)) return true; else return false;
//    }

//    static void Main(string[] args)
//    {
//        for (int i = 10; i <= 100; i++)
//            if (Check(i)) Console.WriteLine(i);
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int x;
//        Console.WriteLine("Введите возраст, до 50 лет:");
//        x = int.Parse(Console.ReadLine());
//        string s = "Вам " + x;
//        // Год - когда заканчивается на один, кроме 11.
//        if (x % 10 == 1 && x != 11) s += " год";
//        else
//            // Года
//            if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " года";
//            else
//                // Лет
//                if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " лет";

//        Console.WriteLine(s);
//    }

//}




//using System;

//class Program
//{
//    static void Main()
//    {
//        int k = 0, s = 0;
//        Console.WriteLine("Введите число:");
//        int a = int.Parse(Console.ReadLine());
//        while (a != 0)
//        {
//            if (a > 0 && a % 8 == 0) { k++; s = s + a; }
//            a = int.Parse(Console.ReadLine());
//        }
//        Console.WriteLine((double)s / k);
//    }
//}



//using System;

//class Program
//{
//    static bool IsSimple(int n)
//    {
//        for (int i = 2; i <= n / 2; i++)
//            if (n % i == 0) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        DateTime start = DateTime.Now;
//        int k = 0;
//        for (int i = 2; i < 1000000; i++)
//            if (IsSimple(i))
//            {
//                k++;
//                Console.WriteLine("{0} {1}", k, i);
//            }
//        Console.WriteLine(k);
//        Console.WriteLine(DateTime.Now - start);
//    }
//}




//using System;

//class Program
//{
//    //static uint Factorial(uint n)
//    //{
//    //    uint res = 1;
//    //    for (uint i = 0; i <= n; i++)
//    //        if (i == 0)
//    //            res = 1;
//    //        else
//    //            res *= i;
//    //    return res;
//    //}

//    static uint Factorial(uint n)
//    {
//        if (n == 0) return 1;
//        else return Factorial(n - 1) * n;
//    }


//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        uint n = Convert.ToUInt32(Console.ReadLine());
//        Console.WriteLine(Factorial(n));
//    }
//}



//using System;

//class Program
//{
//    static uint Fib(uint n)
//    {
//        uint a0 = 0;
//        uint a1 = 1;
//        uint a = a1;
//        for (int i = 2; i <= n; i++)
//        {
//            a = a0 + a1;
//            a0 = a1;
//            a1 = a;
//        }
//        return a1;
//    }

//    //static uint Fib(uint n)
//    //{
//    //    if (n == 0) return 0;
//    //    if (n == 1) return 1;
//    //    return Fib(n - 1) + Fib(n - 2);
//    //}

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        uint n = Convert.ToUInt32(Console.ReadLine());
//        Console.WriteLine(Fib(n));
//    }
//}



//using System;

//class Program
//{

//    static void Move(int number, int from, int to, int free)
//    {
//        if (number > 0)
//        {
//            Move(number - 1, from, free, to);
//            Console.WriteLine("{0} => {1}", from, to);
//            Move(number - 1, free, to, from);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Move(4, 1, 2, 3);
//    }
//}



