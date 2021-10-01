using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzClassLibrary
{
    public class FizzBuzzApplication<T> : IFizzBuzzApplication<T>
    {
        public string LowestDivisibleName { get; set; }
        public string HighestDivisibleName { get; set; }
        public string CombinedDivisibleName { get; set; }
        public T LowestDivisible { get; set; }
        public T HighestDivisible { get; set; }
        public T CombinedDivisible { get; set; }

        public FizzBuzzApplication(T lowestDivisible, T highestDivisible, T combinedDivisible, 
            string lowestDivisibleName = null, string highestDivisibleName = null, string combinedDivisibleName = null)
        {
            LowestDivisibleName = lowestDivisibleName;
            HighestDivisibleName = highestDivisibleName;
            CombinedDivisibleName = combinedDivisibleName;

            LowestDivisible = lowestDivisible;
            HighestDivisible = highestDivisible;
            CombinedDivisible = combinedDivisible;
        }

        public IEnumerable<string> GetFizzBuzzInList(int upperBounds)
        {
            T checkType = default(T);
            if (checkType is int)
            {
                return ProcessIntFizzBuzz(upperBounds);
            }
            else if (checkType is double)
            {
                return ProcessDoubleFizzBuzz(upperBounds);
            }
            else if (checkType is decimal)
            {
                return ProcessDecimalFizzBuzz(upperBounds);
            }
            else if (checkType is float)
            {
                return ProcessFloatFizzBuzz(upperBounds);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        private IEnumerable<string> ProcessFloatFizzBuzz(int upperBounds)
        {
            return Enumerable.Range(1, upperBounds).Select(i =>
                (float)Convert.ChangeType(i, typeof(float)) % (float)Convert.ChangeType(CombinedDivisible, typeof(float)) == 0 ? CombinedDivisibleName :
                (float)Convert.ChangeType(i, typeof(float)) % (float)Convert.ChangeType(LowestDivisible, typeof(float)) == 0 ? LowestDivisibleName :
                (float)Convert.ChangeType(i, typeof(float)) % (float)Convert.ChangeType(HighestDivisible, typeof(float)) == 0 ? HighestDivisibleName :
                Convert.ChangeType(i, typeof(float)).ToString());
        }

        private IEnumerable<string> ProcessDecimalFizzBuzz(int upperBounds)
        {
            return Enumerable.Range(1, upperBounds).Select(i =>
                (decimal)Convert.ChangeType(i, typeof(decimal)) % (decimal)Convert.ChangeType(CombinedDivisible, typeof(decimal)) == 0 ? CombinedDivisibleName :
                (decimal)Convert.ChangeType(i, typeof(decimal)) % (decimal)Convert.ChangeType(LowestDivisible, typeof(decimal)) == 0 ? LowestDivisibleName :
                (decimal)Convert.ChangeType(i, typeof(decimal)) % (decimal)Convert.ChangeType(HighestDivisible, typeof(decimal)) == 0 ? HighestDivisibleName :
                Convert.ChangeType(i, typeof(decimal)).ToString());
        }

        private IEnumerable<string> ProcessDoubleFizzBuzz(int upperBounds)
        {
            return Enumerable.Range(1, upperBounds).Select(i =>
                (double)Convert.ChangeType(i, typeof(double)) % (double)Convert.ChangeType(CombinedDivisible, typeof(double)) == 0 ? CombinedDivisibleName :
                (double)Convert.ChangeType(i, typeof(double)) % (double)Convert.ChangeType(LowestDivisible, typeof(double)) == 0 ? LowestDivisibleName :
                (double)Convert.ChangeType(i, typeof(double)) % (double)Convert.ChangeType(HighestDivisible, typeof(double)) == 0 ? HighestDivisibleName :
                Convert.ChangeType(i, typeof(double)).ToString());
        }

        private IEnumerable<string> ProcessIntFizzBuzz(int upperBounds)
        {
            return Enumerable.Range(1, upperBounds).Select(i =>
                (int)Convert.ChangeType(i, typeof(int)) % (int)Convert.ChangeType(CombinedDivisible, typeof(int)) == 0 ? CombinedDivisibleName :
                (int)Convert.ChangeType(i, typeof(int)) % (int)Convert.ChangeType(LowestDivisible, typeof(int)) == 0 ? LowestDivisibleName :
                (int)Convert.ChangeType(i, typeof(int)) % (int)Convert.ChangeType(HighestDivisible, typeof(int)) == 0 ? HighestDivisibleName :
                Convert.ChangeType(i, typeof(int)).ToString());
        }
    }
}
