using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            var generator = new FibonacciGenerator();

            for (var i = 0; i < 120; i++)
            {
                Console.Write(generator.GenerateFibonacci(i) + ",");
                
                if (i > 0 && i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}