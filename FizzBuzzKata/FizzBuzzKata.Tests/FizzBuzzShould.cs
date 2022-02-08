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
    }
}