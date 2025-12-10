using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> minInt = (x, y) => x < y ? x : y;

            int int1 = 10;
            int int2 = 45;
            int resultInt = minInt(int1, int2);

            Console.WriteLine("--- Цілі числа ---");
            Console.WriteLine($"Числа: {int1}, {int2}");
            Console.WriteLine($"Менше число: {resultInt}");
            Func<double, double, double> minDouble = (x, y) => x < y ? x : y;

            double d1 = 5.55;
            double d2 = 5.54;
            double resultDouble = minDouble(d1, d2);

            Console.WriteLine("\n--- Дійсні числа ---");
            Console.WriteLine($"Числа: {d1}, {d2}");
            Console.WriteLine($"Менше число: {resultDouble}");

            Console.ReadKey();
        }
    }
}