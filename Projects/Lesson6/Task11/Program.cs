using System;
using System.IO;
namespace BigSeries
{
    class Program
    {
        static void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 100000));      // int -занимает 4 байта
            }
            fs.Close();
            bw.Close();
        }
        static void Load(string fileName)
        {
            DateTime d = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] a = new int[fs.Length / 4];
            for (int i = 0; i < fs.Length / 4; i++)    // int занимает 4 байта
            {
                a[i] = br.ReadInt32();
                // if (i % 3 == 0) Console.WriteLine("{0,3} {1}", i, a);
            }
            br.Close();
            fs.Close();
            int max = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length; j++)
                    if (Math.Abs(i - j) >= 8 && a[i] * a[j] > max) max = a[i] * a[j];
            Console.WriteLine(max);
            Console.WriteLine(DateTime.Now - d);
        }
        static void Main(string[] args)
        {
            Save("data.bin", 100000);
            Load("data.bin");
            Console.ReadKey();
        }
    }
}
