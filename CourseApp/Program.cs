// Вариант 22
using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double x)
        {
            var lg = Math.Log10(Math.Pow(x, 2) - 1);

            var c = Math.Pow(a, Math.Pow(x, 2) - 1) - lg + Math.Pow(Math.Pow(x, 2) - 1, 1 / 3);
            return c;
        }

        public static List<double> TaskA(
                                         double a,
                                         double xn,
                                         double xk,
                                         double dx)
        {
            List<double> y = new List<double>();
            for (var x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(a, x));
            }

            return y;
        }

        public static List<double> TaskB(
                                 double a,
                                 List<double> x)
        {
            List<double> y = new List<double>(5);
            foreach (double i in x)
            {
                y.Add(MyFunction(a, i));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            var pieces = new PieceOfArt[] { new Film(), new Picture() };

            for (int i = 0; i < 2; i++)
            {
             Console.WriteLine(pieces[i].Send("Tommy"));
            }

            Console.WriteLine("hELLO");
            List<double> taskA = TaskA(2.25, 1.2, 2.7, 0.3);

            foreach (var item in taskA)
            {
                Console.WriteLine($"y={item}");
            }

            List<double> xB = new List<double>() { 1.31, 1.39, 1.44, 1.56, 1.92 };
            List<double> taskB = TaskB(2, xB);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"x={xB[i]}");
            }

            foreach (var item in taskB)
            {
                Console.WriteLine($"y={item}");
            }

            Console.ReadLine();
        }
    }
}