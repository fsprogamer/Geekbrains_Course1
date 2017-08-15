﻿using System;
using System.IO;
namespace SeriesN_SortMaxMinMiddle
{
    class MyArray
    {
        int[] a;
        public MyArray(string filename)
        {
            StreamReader sr = new StreamReader("..\\..\\data.txt");
            //  Считываем количество элементов массива
            int N = int.Parse(sr.ReadLine());
            a = new int[N];
            //  Считываем массив
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }
        public int Length
        {
            get
            {
                return a.Length;
            }
        }
        public double Sum
        {
            get
            {
                double sum = 0;
                foreach (int el in a)
                    sum += el;
                return sum;
            }
        }
        public int Max
        {
            get
            {
                //  Находим максимальный элемент
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                //  Находим минимальный элемент
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public void BubbleSort()
        {
            //  Сортируем используя сортировку методом "пузырька"
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length - 1; j++)
                    if (a[j] > a[j + 1])//Сравниваем соседние элементы
                    {
                        //  Обмениваем элементы местами
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
        }
        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
        }
        public void Print(string msg)
        {
            Console.WriteLine(msg);
            Print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray("data.txt");
            a.Print();
            Console.WriteLine("\nMax:{0}", a.Max);
            Console.WriteLine("Min:{0}", a.Min);
            Console.WriteLine("Middle:{0}\n", a.Sum / a.Length);
            a.BubbleSort();
            a.Print("Отсортированный массив");
            Console.WriteLine();
        }
    }
}
