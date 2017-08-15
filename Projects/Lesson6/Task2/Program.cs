using System;
using System.IO;// для работы с потоками ввода-вывода
class Program
{
    static void Main()
    {
        try
        {
            FileStream fileIn = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            FileStream fileOut = new FileStream("newData.txt", FileMode.Create, FileAccess.Write);
            int i;
            while ((i = fileIn.ReadByte()) != -1)
            {
                //  запись очередного байта в поток, связанный с файлом fileOut
                fileOut.WriteByte((byte)i);
            }
            fileIn.Close();
            fileOut.Close();
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
        Console.WriteLine("Файл успешно скопирован");
    }
}

