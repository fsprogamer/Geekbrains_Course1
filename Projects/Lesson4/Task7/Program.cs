class Program
{
    static void Main(string[] args)
    {
        // Объявление массива массивов(ступенчатый массив)
        int[][] jaggedArray = new int[3][];
        // Пример заполнения первого элемента ступенчатого массива
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        jaggedArray[1] = new int[5] { 1, 2, 3, 4, 5 };
        jaggedArray[2] = new int[3] { 1, 2, 3 };
    }
}

