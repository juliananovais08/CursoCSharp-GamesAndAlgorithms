using System;

namespace _01_Factorial_loopings_recursion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth value as integer:");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"LOOP1 Calulation: Factorial od {n} is {CalculateLoop1(n)}");
            Console.WriteLine($"LOOP2 Calulation: Factorial od {n} is {CalculateLoop2(n)}");

            Console.WriteLine($"Recursion Calulation: Factorial od {n} is {CalculateRecursion(n)}");
        }

        private static int CalculateLoop1(int n)
        {
            var factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        private static int CalculateLoop2(int n)
        {
            var factorial = n;
            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        private static int CalculateRecursion(int n)
        {
            if (n == 1)
                return 1;
            return n * CalculateRecursion(n - 1);
        }
    }
}