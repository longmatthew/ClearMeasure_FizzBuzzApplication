using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzClassLibrary
{
    public interface IFizzBuzzApplication<T>
    {
        public T LowestDivisible { get; set; }
        public T HighestDivisible { get; set; }
        public T CombinedDivisible { get; set; }

        public IEnumerable<string> GetFizzBuzzInList(int upperBounds);
    }
}
