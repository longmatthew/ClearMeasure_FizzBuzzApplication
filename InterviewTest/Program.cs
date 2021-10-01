using FizzBuzzClassLibrary;
using System;
using System.Collections.Generic;

namespace InterviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzApplication<int> fizzBuzzApplication = new FizzBuzzApplication<int>(3, 5, 15, "BUZZ", "FIZZ", "FIZZBUZZ");
            IEnumerable<string> consoleFizzBuzzList = fizzBuzzApplication.GetFizzBuzzInList(int.MaxValue);

            if (consoleFizzBuzzList != null)
            {
                foreach (string item in consoleFizzBuzzList)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
