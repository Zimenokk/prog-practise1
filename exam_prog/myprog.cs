namespace exam_prog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class myprog
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перший член прогрессії");
        double a1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Крок:");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Скільки членів в нашій прогресії:");
        int n=int.Parse(Console.ReadLine());
        double Sum = 0; 
        for(int i=1; i<=n;i++) Sum=(2*a1+d*(n-1))*n/2;
        Console.WriteLine("Сума прогресії:  "+ Sum);
    }
}