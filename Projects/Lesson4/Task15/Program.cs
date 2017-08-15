using System;
namespace EGE_Matrix
{
    class Matrix
    {
        int[,] a;     // Матрица
        int[] Rows;   // Сумма строк этой матрицы
        public Matrix(int n, int m)
        {
            a = new int[n, m];
            Random rnd = new Random();
            Rows = new int[n];
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(0, 10);
                    // Подсчет сумм каждой строки
                    s += a[i, j];
                }
                // Сохранение суммы для каждой строки
                Rows[i] = s;
            }
        }

        // Вывод матрицы на экран
        public void Print()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write("{0,4}", a[i, j]);
                Console.WriteLine();
            }
        }
        // Метод Search находит минимальную сумму и возвращает количество таких строк
        public int Search(out int count)
        {
            int min = int.MaxValue;
            count = 0;         // count описывать не нужно
            foreach (int e in Rows)
            {
                if (e < min) min = e;
            }
            foreach (int e in Rows)
            {
                if (e == min) count++;
            }
            return min;
        }
        // Находим все строки с такой же суммой
        public void SearchRows()
        {
            int countRow;// Количество минимальных элементов
            int min = Search(out countRow); ;
            for (int i = 0; i < Rows.Length; i++)
            {
                if (Rows[i] == min)
                {
                    Console.WriteLine("\n{0} {1}", i, Rows[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(5, 2);
            a.Print();
            a.SearchRows();
            Console.ReadKey();
        }
    }
}
