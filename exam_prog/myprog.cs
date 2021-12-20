namespace exam_prog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class myprog
{
    public static void Main(string[] args)
    {
        Console.WriteLine("01.03.2002");
        Console.WriteLine("Введіть перший член прогрессії");
        double a1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Крок:");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Скільки членів в нашій прогресії:");
        int n=int.Parse(Console.ReadLine());

        double result = Method(a1,  d,  n);
        Console.WriteLine(result);
    }

    public static double Method(double a1, double d, int n)
    {
        double Sum = 0; 
        for(int i=1; i<=n;i++) Sum=(2*a1+d*(n-1))*n/2;
        return Sum;
    }
}