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
        
        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void ReturnBuzzWhenMultipleOf5(int number, string expected)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void ReturnFizzBuzzWhenMultipleOf3And5(int number, string expected)
        {
            var result = FizzBuzzer.FizzBuzz(number);
            result.Should().Be(expected);
        }
        
     }
}