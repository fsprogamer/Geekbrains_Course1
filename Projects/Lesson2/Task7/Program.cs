using System;

class Program
{
    static void Main()
    {

        int m = 6;
        string s;
        switch (m)
        {
            case 1:
            case 2:
            case 12:
                s = "Зима";
                break;
            case 3:
            case 4:
            case 5:
                s = "Весна";
                break;
            case 6:
            case 7:
            case 8:
                s = "Лето";
                break;
            case 9:
            case 10:
            case 11:
                s = "Осень";
                break;
            default:
                s = "Ничего";
                break;
        }
        Console.WriteLine(s);
    }
}