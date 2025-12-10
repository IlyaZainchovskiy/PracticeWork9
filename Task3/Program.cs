using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;
            int number1 = 10;
            int number2 = 7;
            int number3 = -4;

            Console.WriteLine($"Число {number1} є парним: {isEven(number1)}");
            Console.WriteLine($"Число {number2} є парним: {isEven(number2)}");
            Console.WriteLine($"Число {number3} є парним: {isEven(number3)}");

            Console.Write("\nВведіть число: ");
            if (int.TryParse(Console.ReadLine(), out int inputNum))
            {
                if (isEven(inputNum))
                {
                    Console.WriteLine("Це парне число.");
                }
                else
                {
                    Console.WriteLine("Це непарне число.");
                }
            }
            else
            {
                Console.WriteLine("Некоректне введення.");
            }

            Console.ReadKey();
        }
    }
}