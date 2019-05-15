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
        [InlineData(4, 5)]
        [InlineData(5, 8)]
        [InlineData(6, 13)]
        [InlineData(7, 21)]
        [InlineData(8, 34)]
        [InlineData(9, 55)]
        [InlineData(10, 89)]
        [InlineData(11, 144)]
        public void ShouldReturnTheSumOfTheTwoPriorNumberWHenInputN(int inputNumber, int expected)
        {
            var fibonacci = _fibonacciGenerator.GenerateFibonacci(inputNumber);
            
            Assert.Equal(expected, fibonacci);
        }
    }
}