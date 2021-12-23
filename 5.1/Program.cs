using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.1, 2-й вариант, высокий уровень, Гребенюк А. 21-ИСП-2.
            Console.WriteLine("Введите число: ");
            double x = double.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(x + ", возведенное в n = " + Power(x, n));
            }
        }
        static double Power(double x, int n)
        {
            if (n == 1)
                return (x);
            return x * Power(x, n - 1);
        }
    }
}
