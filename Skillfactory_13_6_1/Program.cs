using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var list = new List<string>();
        LinkedList<string> l = new LinkedList<string>();
        string text = File.ReadAllText(@"C:\Users\Toshka\Desktop\Text1.txt");

        //Засекаем обычный список
        var watchOne = Stopwatch.StartNew();
        list.Add(text);
        var a = watchOne.Elapsed.TotalMilliseconds;
        Console.WriteLine($"Вставка в обычный список: {a}  мс");


        //Засекаем связанный список
        var watchTwo = Stopwatch.StartNew();
        list.Add(text);
        var b = watchTwo.Elapsed.TotalMilliseconds;
        Console.WriteLine($"Вставка в связанный список: {b}  мс");

        //Вычисляем разницу
        var raznitsa = (a - b);
        Console.WriteLine($"Вставка текста в связанный список быстрее на {raznitsa} мс");
    }
}