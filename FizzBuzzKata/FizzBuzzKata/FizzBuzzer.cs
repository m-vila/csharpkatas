namespace FizzBuzzKata
{
    // 3 = Fizz
    // 5 = Buzz
    // 3 y de 5 = FizzBuzz
    public class FizzBuzzer
    {
        public static object FizzBuzz(int number)
        {
            if (number == 3)
                return "Fizz";
            return number;
        }
    }
}