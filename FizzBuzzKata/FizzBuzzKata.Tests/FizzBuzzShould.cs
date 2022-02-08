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
        
        [Fact]
        public void ReturnFizzWhen3()
        {
            var result = FizzBuzzer.FizzBuzz(3); 
            result.Should().Be("Fizz");
        }

     }
}