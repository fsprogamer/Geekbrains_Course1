﻿using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string lastName;
    public string firstName;
    public string univercity;
    public string faculty;
    public int course;
    public string department;
    public int group;
    public string city;
    int age;
    // Создаем конструктор
    public Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.univercity = univercity;
        this.faculty = faculty;
        this.department = department;
        this.course = course;
        this.age = age;
        this.group = group;
        this.city = city;
    }
}
class Program
{
    static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
    {
        return String.Compare(st1.firstName, st2.firstName);// Сравниваем две строки
    }
    static void Main(string[] args)
    {
        int bakalav = 0;
        int magistr = 0;
        List<Student> list = new List<Student>();           // Создаем список студентов
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("students_6.csv");
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                // Одновременно подсчитываем количество бакалавров и магистров
                if (int.Parse(s[6]) < 5) bakalav++; else magistr++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();
        list.Sort(new Comparison<Student>(MyDelegat));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalav);
        foreach (var v in list) Console.WriteLine(v.firstName);
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}

