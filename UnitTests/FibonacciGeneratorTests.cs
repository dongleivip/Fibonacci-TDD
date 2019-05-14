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
        public void ShouldReturnOneWhenInputOne()
        {
            var fibonacci = _fibonacciGenerator.GenerateFibonacci(1);
            
            Assert.Equal(1, fibonacci);
        }
    }
}