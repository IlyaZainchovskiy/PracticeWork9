using System;

namespace Task4
{
    internal class Program
    {
        static int FibonacciMethod(int n)
        {
            if (n <= 1) return n;
            return FibonacciMethod(n - 1) + FibonacciMethod(n - 2);
        }

        static void Main(string[] args)
        {
            Func<int, int> fibLambda = null;

            fibLambda = (n) =>
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return fibLambda(n - 1) + fibLambda(n - 2);
                }
            };

            Console.Write("Введіть номер числа Фібоначчі (n): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int resultMethod = FibonacciMethod(n);
                Console.WriteLine($"\nРезультат: F({n}) = {resultMethod}");

                int resultLambda = fibLambda(n);
                Console.WriteLine($"Результат лямбда-вираз:  F({n}) = {resultLambda}");
            }
            else
            {
                Console.WriteLine("Введіть коректне ціле число.");
            }

            Console.ReadKey();
        }
    }
}