using System;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
        // F(n) = F(n-1) + F(n-2)
//        public long GenerateFibonacci(int number)
//        {
//            if (number == 0 || number == 1)
//            {
//                return 1;
//            }
//
//            var priorFirst = GenerateFibonacci(number - 1);
//            var priorSecond = GenerateFibonacci(number - 2);
//            
//            var result = priorFirst + priorSecond;
//
//            return result;
//        }
        
        
        public long GenerateFibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            
            long fibNMinusOne = 1;
            long fibNMinusTwo = 1;
            long fibN = 0;

            for (var i = 2; i <= number; i++)
            {
                fibN = fibNMinusOne + fibNMinusTwo;

                fibNMinusTwo = fibNMinusOne;
                fibNMinusOne = fibN;
            }

            return fibN;
        }
    }
}