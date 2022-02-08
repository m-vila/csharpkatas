using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnOneWhenOne()
        {
            var result = FizzBuzzer.FizzBuzz(1);
            result.Should().Be(1);
        }

        [Fact]
        public void ReturnTwoWhenTwo()
        {
            var result = FizzBuzzer.FizzBuzz(2);
            result.Should().Be(2);
        }

        [Fact]
        public void ReturnFizzWhen3()
        {
            var result = FizzBuzzer.FizzBuzz(3); 
            result.Should().Be("Fizz");
        }
    }
}