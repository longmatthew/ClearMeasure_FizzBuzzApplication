using FizzBuzzClassLibrary;
using System;

namespace FizzBuzzUnitTest
{
    public class FizzBuzzUnitTestFixture : IDisposable
    {
        public FizzBuzzApplication<int> DefaultIntFizzBuzz { get; private set; } = 
            new FizzBuzzApplication<int>(3, 5, 15, "BUZZ", "FIZZ", "FIZZBUZZ");
        public FizzBuzzApplication<decimal> DefaultDecimalFizzBuzz { get; private set; } =
            new FizzBuzzApplication<decimal>(3.0m, 5.0m, 15.0m, "BUZZ", "FIZZ", "FIZZBUZZ");
        public FizzBuzzApplication<double> DefaultDoubleFizzBuzz { get; private set; } =
            new FizzBuzzApplication<double>(3.0, 5.0, 15.0, "BUZZ", "FIZZ", "FIZZBUZZ");
        public FizzBuzzApplication<float> DefaultFloatFizzBuzz { get; private set; } =
            new FizzBuzzApplication<float>(3f, 5f, 15f, "BUZZ", "FIZZ", "FIZZBUZZ");
        public FizzBuzzApplication<int> DynamicFizzBuzz { get; set; }

        public FizzBuzzUnitTestFixture()
        {
        }

        public void Dispose()
        {
            DefaultIntFizzBuzz = null;
            DefaultDecimalFizzBuzz = null;
            DefaultDoubleFizzBuzz = null;
            DefaultFloatFizzBuzz = null;
            DynamicFizzBuzz = null;
        }
    }
}
