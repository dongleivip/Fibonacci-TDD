using System;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
        // F(n) = F(n-1) + F(n-2)
        public int GenerateFibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            var priorFirst = GenerateFibonacci(number - 1);
            var priorSecond = GenerateFibonacci(number - 2);
            
            var result = priorFirst + priorSecond;

            return result;
        }
    }
}