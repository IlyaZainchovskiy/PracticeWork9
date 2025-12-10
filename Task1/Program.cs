using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введіть значення x: ");

                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Func<double, double> lambdaLessOrEqual = val => 4 * val - 1;
                    Func<double, double> lambdaGreater = val => 25 * val + 10;

                    double result;
                    if (x <= 0)
                    {
                        result = lambdaLessOrEqual(x);
                        Console.WriteLine($"Обрано умову x <= 0. Формула: 4x - 1");
                    }
                    else
                    {
                        result = lambdaGreater(x);
                        Console.WriteLine($"Обрано умову x > 0. Формула: 25x + 10");
                    }

                    Console.WriteLine($"Результат F({x}) = {result}");
                }
                else
                {
                    Console.WriteLine("Помилка: Введено некоректне число.");
                }

                Console.WriteLine("\nБажаєте продовжити? (y/n): ");
                string answer = Console.ReadLine()?.ToLower();

                if (answer != "y" && answer != "д" && answer != "yes")
                {
                    Console.WriteLine("Програму завершено.");
                    break;
                }

                Console.Clear();
            }
        }
    }
}
