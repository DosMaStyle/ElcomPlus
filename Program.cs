using System;

namespace HW1
{
    class Program
    {
        static double Func(double x)
        {
            return Math.Pow(x + 1, 3) + Math.Pow(5 * x, 2);
        }

        static double Max(double a, double b, double eps)
        {
            double F = (1 + Math.Sqrt(5)) / 2;
            double x1, x2, y1, y2, x;

            while (Math.Abs(b - a) > eps)
            {
                x1 = b - (b - a) / F;
                x2 = b + (b - a) / F;

                y1 = Func(x1);
                y2 = Func(x2);

                if (y1 <= y2)
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }

            }
            x = (a + b) / 2;
            return x;
        }

        static double Min(double a, double b, double eps)
        {
            double F = (1 + Math.Sqrt(5)) / 2;
            double x1, x2, y1, y2, x;

            while (Math.Abs(b - a) > eps)
            {
                x1 = b - (b - a) / F;
                x2 = b + (b - a) / F;

                y1 = Func(x1);
                y2 = Func(x2);

                if (y1 >= y2)
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }

            }
            x = (a + b) / 2;
            return x;
        }
        static void Main(string[] args)
        {
            double a = -2;
            double b = 2;
            double eps = 0.001;
            double max = Max(a, b, eps);
            double min = Min(a, b, eps);

            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);
        }
    }
}
