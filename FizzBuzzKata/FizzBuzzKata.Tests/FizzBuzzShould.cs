using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzShould
    {

        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(4,4)]
        public void ReturnTheSameInputNumber(int number, int expected)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        public void ReturnFizzWhenMultipleOf3(int number, string expected)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            result.Should().Be(expected);
        }
        
       [Fact]
        public void ReturnBuzzWhen5()
        {
            var result = FizzBuzzer.FizzBuzz(5); 
            result.Should().Be("Buzz");
        }

        
     }
}