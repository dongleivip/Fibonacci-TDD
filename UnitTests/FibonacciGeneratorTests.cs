using Fibonacci;
using Xunit;

namespace UnitTests
{
    public class FibonacciGeneratorTests
    {
        private FibonacciGenerator _fibonacciGenerator;
        
        public FibonacciGeneratorTests()
        {
            _fibonacciGenerator = new FibonacciGenerator();
        }
        
        [Fact]
        public void ShouldReturnOneWhenInputZero()
        {
            var fibonacci = _fibonacciGenerator.GenerateFibonacci(0);
            
            Assert.Equal(1, fibonacci);
        }

        [Fact]
        public void ShouldReturnOneWhenInputOne()
        {
            var fibonacci = _fibonacciGenerator.GenerateFibonacci(1);
            
            Assert.Equal(1, fibonacci);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void ShouldReturnTheSumOfTheTwoPriorNumberWHenInputN(int inputNumber, int expected)
        {
            var fibonacci = _fibonacciGenerator.GenerateFibonacci(inputNumber);
            
            Assert.Equal(expected, fibonacci);
        }
    }
}