using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FizzBuzzUnitTest
{
    public class FizzBuzzUnitTestClass : IClassFixture<FizzBuzzUnitTestFixture>
    {
        public string FizzStr = "FIZZ";
        public string BuzzStr = "BUZZ";
        public string FizzBuzzStr = "FIZZBUZZ";

        FizzBuzzUnitTestFixture FizzBuzzUnitTestFixture { get; set; }

        public FizzBuzzUnitTestClass(FizzBuzzUnitTestFixture testFixture)
        {
            this.FizzBuzzUnitTestFixture = testFixture;
        }

        [Fact]
        public void FizzBuzzApplication_DefaultIntFizzBuzz_Returns10ItemList()
        {
            // Arrange
            List<string> expectedList = new List<string>
            {
                "1", "2", BuzzStr, "4", FizzStr, BuzzStr, "7", "8", BuzzStr, FizzStr
            };

            // Act
            List<string> resultList = this.FizzBuzzUnitTestFixture.DefaultIntFizzBuzz.GetFizzBuzzInList(10).ToList();

            // Assert
            Assert.NotNull(resultList);
            Assert.NotEmpty(resultList);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DefaultIntFizzBuzz_ZeroUpperBoundsReturnsEmptyList()
        {
            // Arrange

            // Act
            IEnumerable<string> resultList = this.FizzBuzzUnitTestFixture.DefaultDecimalFizzBuzz.GetFizzBuzzInList(0);

            // Assert
            Assert.Empty(resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DefaultDoubleFizzBuzz_Returns10ItemList()
        {
            // Arrange
            List<string> expectedList = new List<string>
            {
                "1", "2", BuzzStr, "4", FizzStr, BuzzStr, "7", "8", BuzzStr, FizzStr
            };

            // Act
            List<string> resultList = this.FizzBuzzUnitTestFixture.DefaultDoubleFizzBuzz.GetFizzBuzzInList(10).ToList();

            // Assert
            Assert.NotNull(resultList);
            Assert.NotEmpty(resultList);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DefaultDoubleFizzBuzz_ZeroUpperBoundsReturnsEmptyList()
        {
            // Arrange

            // Act
            IEnumerable<string> resultList = this.FizzBuzzUnitTestFixture.DefaultDecimalFizzBuzz.GetFizzBuzzInList(0);

            // Assert
            Assert.Empty(resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DefaultFloatFizzBuzz_Returns10ItemList()
        {
            // Arrange
            List<string> expectedList = new List<string>
            {
                "1", "2", BuzzStr, "4", FizzStr, BuzzStr, "7", "8", BuzzStr, FizzStr
            };

            // Act
            List<string> resultList = this.FizzBuzzUnitTestFixture.DefaultFloatFizzBuzz.GetFizzBuzzInList(10).ToList();

            // Assert
            Assert.NotNull(resultList);
            Assert.NotEmpty(resultList);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DefaultFloatFizzBuzz_ZeroUpperBoundsReturnsEmptyList()
        {
            // Arrange

            // Act
            IEnumerable<string> resultList = this.FizzBuzzUnitTestFixture.DefaultDecimalFizzBuzz.GetFizzBuzzInList(0);

            // Assert
            Assert.Empty(resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DefaultDecimalFizzBuzz_Returns10ItemList()
        {
            // Arrange
            List<string> expectedList = new List<string>
            {
                "1", "2", BuzzStr, "4", FizzStr, BuzzStr, "7", "8", BuzzStr, FizzStr
            };

            // Act
            List<string> resultList = this.FizzBuzzUnitTestFixture.DefaultDecimalFizzBuzz.GetFizzBuzzInList(10).ToList();

            // Assert
            Assert.NotNull(resultList);
            Assert.NotEmpty(resultList);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DefaultDecimalFizzBuzz_ZeroUpperBoundsReturnsEmptyList()
        {
            // Arrange

            // Act
            IEnumerable<string> resultList = this.FizzBuzzUnitTestFixture.DefaultDecimalFizzBuzz.GetFizzBuzzInList(0);

            // Assert
            Assert.Empty(resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DynamicFizzBuzz_ZeroUpperBoundsReturnsEmptyList()
        {
            // Arrange
            this.FizzBuzzUnitTestFixture.DynamicFizzBuzz = new FizzBuzzClassLibrary.FizzBuzzApplication<int>(7, 8, 9, "THIS", "IS", "ATEST");

            // Act
            IEnumerable<string> resultList = this.FizzBuzzUnitTestFixture.DynamicFizzBuzz.GetFizzBuzzInList(0);

            // Assert
            Assert.Empty(resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DynamicFizzBuzz_TestDynamicDivisibleNames()
        {
            // Arrange
            this.FizzBuzzUnitTestFixture.DynamicFizzBuzz = new FizzBuzzClassLibrary.FizzBuzzApplication<int>(7, 8, 9, "THIS", "IS", "ATEST");
            List<string> expectedList = new List<string>
            {
                "1", "2", "3", "4", "5", "6", "THIS", "IS", "ATEST", "10"
            };
            // Act
            List<string> resultList = this.FizzBuzzUnitTestFixture.DynamicFizzBuzz.GetFizzBuzzInList(10).ToList();

            // Assert
            Assert.NotNull(resultList);
            Assert.NotEmpty(resultList);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void FizzBuzzApplication_DynamicFizzBuzz_TestNullDivisibleNames()
        {
            // Arrange
            this.FizzBuzzUnitTestFixture.DynamicFizzBuzz = new FizzBuzzClassLibrary.FizzBuzzApplication<int>(7, 8, 9);
            List<string> expectedList = new List<string>
            {
                "1", "2", "3", "4", "5", "6", null, null, null, "10"
            };
            // Act
            List<string> resultList = this.FizzBuzzUnitTestFixture.DynamicFizzBuzz.GetFizzBuzzInList(10).ToList();

            // Assert
            Assert.NotNull(resultList);
            Assert.NotEmpty(resultList);

            Assert.Equal(expectedList, resultList);
        }
    }
}
