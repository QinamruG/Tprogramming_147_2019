// Вариант 22
using System;

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

        public static double[] TaskA(
                                         double a,
                                         double xn,
                                         double xk,
                                         double dx)
            {
                var steps = (int)Math.Floor((xk - xn) / dx) + 1;
                var y = new double[steps];
                var i = 0;
                for (var x = xn; x < xk; x += dx)
                {
                    y[i] = MyFunction(a, x);
                    i++;
                }

                return y;
            }

        public static double[] TaskB (
                                 double a,
                                 double[] x)
            {
                var y = new double[x.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    y[i] = MyFunction(a, x[i]);
                }

                return y;
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                var taskA = TaskA(2.25, 1.2, 2.7, 0.3);

                 // Console.WriteLine(taskA);
                for (var i = 0; i < taskA.Length; i++)
                {
                    Console.WriteLine($"y={taskA[i]}");
                }

                var xB = new double[] { 1.31, 1.39, 1.44, 1.56, 1.92 };
                var taskB = TaskB(2, xB);
                for (var i = 0; i < xB.Length; i++)
                {
                    Console.WriteLine($"x={xB[i]} y={taskB[i]}");
                }

                Console.ReadLine();
            }
    }
}